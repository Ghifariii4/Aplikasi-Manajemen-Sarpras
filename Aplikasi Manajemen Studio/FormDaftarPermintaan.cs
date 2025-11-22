using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormDaftarPermintaan : Form
    {
        private string userJabatan;
        private string idPetugasPenyetuju;
        private string idPermintaanTerpilih;

        public FormDaftarPermintaan(string jabatan, string idPetugas)
        {
            InitializeComponent();
            this.userJabatan = jabatan;
            this.idPetugasPenyetuju = idPetugas;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormDaftarPermintaan_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            TampilkanDataPending();
        }

        private void KondisiAwal()
        {
            dgvDetailPending.DataSource = null;
            idPermintaanTerpilih = null;
            btnSetuju.Enabled = false;
            btnTolak.Enabled = false;
        }

        private void TampilkanDataPending()
        {
            KondisiAwal();
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // Query ini menggabungkan nama pemohon dari Guru atau Siswa
                    string query = @"
                        SELECT 
                            H.ID_Permintaan, 
                            H.Tgl_Permintaan, 
                            ISNULL(G.Nama_Guru, S.Nama_Siswa) AS Pemohon, 
                            H.Status
                        FROM tblPermintaan_Header H
                        LEFT JOIN tblGuru G ON H.ID_Guru_Peminta = G.ID_Guru
                        LEFT JOIN tblSiswa S ON H.ID_Siswa_Peminta = S.ID_Siswa
                        WHERE H.Status = 'Pending'
                        ORDER BY H.Tgl_Permintaan ASC";

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvPending.DataSource = dt;

                    // Styling Kolom
                    dgvPending.Columns["ID_Permintaan"].HeaderText = "ID";
                    dgvPending.Columns["Tgl_Permintaan"].HeaderText = "Tgl. Permintaan";
                    dgvPending.Columns["Tgl_Permintaan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvPending.Columns["Pemohon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar permintaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TampilkanDetail(string idPermintaan)
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            D.ID_Barang, 
                            B.Nama_Barang, 
                            D.Jumlah_Diminta, 
                            B.Stok AS Stok_Saat_Ini
                        FROM tblPermintaan_Detail D
                        JOIN tblBarang B ON D.ID_Barang = B.ID_Barang
                        WHERE D.ID_Permintaan = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idPermintaan);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvDetailPending.DataSource = dt;

                    dgvDetailPending.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat detail permintaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPermintaanTerpilih = dgvPending.Rows[e.RowIndex].Cells["ID_Permintaan"].Value.ToString();
                TampilkanDetail(idPermintaanTerpilih);
                btnSetuju.Enabled = true;
                btnTolak.Enabled = true;
            }
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            if (idPermintaanTerpilih == null) return;

            if (MessageBox.Show("Anda yakin ingin menyetujui permintaan ini? Stok barang akan dikurangi.", "Konfirmasi Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Validasi dan update stok dalam satu perintah
                    foreach (DataGridViewRow row in dgvDetailPending.Rows)
                    {
                        if (row.IsNewRow) continue;
                        int idBarang = Convert.ToInt32(row.Cells["ID_Barang"].Value);
                        int jumlahDiminta = Convert.ToInt32(row.Cells["Jumlah_Diminta"].Value);
                        string namaBarang = row.Cells["Nama_Barang"].Value.ToString();

                        // Perintah UPDATE ini SANGAT PENTING:
                        // Hanya akan berhasil jika Stok >= jumlahDiminta
                        string queryUpdateStok = "UPDATE tblBarang SET Stok = Stok - @jml WHERE ID_Barang = @id AND Stok >= @jml";
                        SqlCommand cmdUpdateStok = new SqlCommand(queryUpdateStok, conn, transaction);
                        cmdUpdateStok.Parameters.AddWithValue("@jml", jumlahDiminta);
                        cmdUpdateStok.Parameters.AddWithValue("@id", idBarang);

                        int rowsAffected = cmdUpdateStok.ExecuteNonQuery();

                        // Jika rowsAffected = 0, berarti stok tidak cukup (kondisi 'AND Stok >= @jml' gagal)
                        if (rowsAffected == 0)
                        {
                            throw new Exception($"Stok untuk '{namaBarang}' tidak mencukupi atau telah habis!");
                        }
                    }

                    // Jika semua stok berhasil dikurangi, update header permintaan
                    string queryUpdateHeader = "UPDATE tblPermintaan_Header SET Status = 'Disetujui', ID_Petugas_Penyetuju = @idPetugas, Tgl_Disetujui = @tgl WHERE ID_Permintaan = @id";
                    SqlCommand cmdUpdateHeader = new SqlCommand(queryUpdateHeader, conn, transaction);
                    cmdUpdateHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPenyetuju);
                    cmdUpdateHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmdUpdateHeader.Parameters.AddWithValue("@id", idPermintaanTerpilih);
                    cmdUpdateHeader.ExecuteNonQuery();

                    // Jika semua berhasil, commit
                    transaction.Commit();
                    MessageBox.Show("Permintaan berhasil disetujui. Stok barang telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm(); // Beri tahu Menu_Utama
                }
                catch (Exception ex)
                {
                    // Jika terjadi error (termasuk stok tidak cukup), batalkan semua
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyetujui permintaan:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Muat ulang data
            TampilkanDataPending();
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (idPermintaanTerpilih == null) return;

            if (MessageBox.Show("Anda yakin ingin menolak permintaan ini? (Stok tidak akan berubah)", "Konfirmasi Penolakan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // Menolak permintaan JAUH lebih sederhana, hanya ubah status
                    string queryUpdateHeader = "UPDATE tblPermintaan_Header SET Status = 'Ditolak', ID_Petugas_Penyetuju = @idPetugas, Tgl_Disetujui = @tgl WHERE ID_Permintaan = @id";
                    SqlCommand cmdUpdateHeader = new SqlCommand(queryUpdateHeader, conn);
                    cmdUpdateHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPenyetuju);
                    cmdUpdateHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmdUpdateHeader.Parameters.AddWithValue("@id", idPermintaanTerpilih);
                    cmdUpdateHeader.ExecuteNonQuery();

                    MessageBox.Show("Permintaan berhasil ditolak.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm(); // Beri tahu Menu_Utama
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menolak permintaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Muat ulang data
            TampilkanDataPending();
        }

        // Metode helper untuk memberitahu Menu_Utama agar me-refresh form lain
        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent)
            {
                parent.NotifyPermintaanChanged();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanDataPending();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}