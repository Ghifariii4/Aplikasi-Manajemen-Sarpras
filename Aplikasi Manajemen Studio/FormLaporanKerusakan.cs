using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormLaporanKerusakan : Form
    {
        private string idPetugasPencatat;

        public FormLaporanKerusakan(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasPencatat = idPetugasLogin;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormLaporanKerusakan_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            LoadBarangKeComboBox();
            LoadRiwayatKerusakan(); // --- BARU: Memuat riwayat saat form dibuka ---
        }

        private void KondisiAwal()
        {
            cmbBarang.SelectedIndex = -1;
            numJumlah.Value = 1;
            txtKeterangan.Clear();
            cmbBarang.Focus();
        }

        private void LoadBarangKeComboBox()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Barang, (Nama_Barang + ' (Stok: ' + CAST(Stok AS VARCHAR) + ')') AS TampilanBarang FROM tblBarang WHERE Stok > 0 ORDER BY Nama_Barang";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmbBarang.DataSource = dt;
                    cmbBarang.DisplayMember = "TampilanBarang";
                    cmbBarang.ValueMember = "ID_Barang";
                    cmbBarang.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data barang. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- METODE BARU: Untuk mengisi DataGridView Riwayat ---
        private void LoadRiwayatKerusakan()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // Query mengambil 20 data kerusakan terakhir, digabung dengan nama barang dan pelapor
                    string query = @"
                        SELECT TOP 20 
                            K.Tgl_Lapor, 
                            B.Nama_Barang, 
                            K.Jumlah, 
                            K.Keterangan, 
                            P.Nama_Lengkap AS [Pelapor]
                        FROM tblKerusakan K
                        JOIN tblBarang B ON K.ID_Barang = B.ID_Barang
                        JOIN tblPetugas P ON K.ID_Petugas_Pelapor = P.ID_Petugas
                        ORDER BY K.Tgl_Lapor DESC";

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvRiwayatKerusakan.DataSource = dt; // Pastikan nama DGV Anda 'dgvRiwayatKerusakan'

                    // Mengatur lebar kolom agar rapi
                    dgvRiwayatKerusakan.Columns["Tgl_Lapor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvRiwayatKerusakan.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvRiwayatKerusakan.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvRiwayatKerusakan.Columns["Keterangan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvRiwayatKerusakan.Columns["Pelapor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat riwayat kerusakan. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // --- BATAS METODE BARU ---

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input
            if (cmbBarang.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih barang yang rusak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numJumlah.Value <= 0)
            {
                MessageBox.Show("Jumlah barang rusak harus lebih dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan kerusakan wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBarang = Convert.ToInt32(cmbBarang.SelectedValue);
            int jumlahRusak = (int)numJumlah.Value;

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 2. Validasi Stok
                    int stokSaatIni = 0;
                    using (SqlCommand cmdCekStok = new SqlCommand("SELECT Stok FROM tblBarang WHERE ID_Barang = @id", conn, transaction))
                    {
                        cmdCekStok.Parameters.AddWithValue("@id", idBarang);
                        object result = cmdCekStok.ExecuteScalar();
                        if (result != null) stokSaatIni = (int)result;
                    }

                    if (stokSaatIni < jumlahRusak)
                    {
                        throw new Exception($"Stok tidak mencukupi. Stok '{cmbBarang.Text}' saat ini hanya {stokSaatIni}.");
                    }

                    // 3. Kurangi Stok di tblBarang
                    using (SqlCommand cmdUpdateStok = new SqlCommand("UPDATE tblBarang SET Stok = Stok - @jumlah WHERE ID_Barang = @id", conn, transaction))
                    {
                        cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlahRusak);
                        cmdUpdateStok.Parameters.AddWithValue("@id", idBarang);
                        cmdUpdateStok.ExecuteNonQuery();
                    }

                    // 4. Catat di tblKerusakan
                    string queryInsert = @"INSERT INTO tblKerusakan (Tgl_Lapor, ID_Barang, Jumlah, Keterangan, ID_Petugas_Pelapor) 
                                           VALUES (@tgl, @idBarang, @jumlah, @keterangan, @idPetugas)";
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@tgl", DateTime.Now);
                        cmdInsert.Parameters.AddWithValue("@idBarang", idBarang);
                        cmdInsert.Parameters.AddWithValue("@jumlah", jumlahRusak);
                        cmdInsert.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);
                        cmdInsert.Parameters.AddWithValue("@idPetugas", this.idPetugasPencatat);
                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Laporan kerusakan berhasil disimpan. Stok barang telah dikurangi.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (SqlException sqlEx)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyimpan laporan. Terjadi masalah database.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show(ex.Message, "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Muat ulang semua
            KondisiAwal();
            LoadBarangKeComboBox();
            LoadRiwayatKerusakan(); // --- BARU: Refresh riwayat setelah simpan ---
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataBarangChanged();
        }

        public void ReloadBarangComboBox()
        {
            object selectedValue = cmbBarang.SelectedValue;
            LoadBarangKeComboBox();
            if (selectedValue != null) cmbBarang.SelectedValue = selectedValue;
        }
    }
}