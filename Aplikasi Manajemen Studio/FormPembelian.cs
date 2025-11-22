using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormPembelian : Form
    {
        private string idPetugasPencatat;

        public FormPembelian(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasPencatat = idPetugasLogin;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            LoadBarangKeComboBox();
            TampilkanData();
        }

        private void KondisiAwal()
        {
            txtNoFaktur.Text = "(Pilih barang untuk generate kode)";
            txtNoFaktur.Enabled = false;

            dtpTanggalBeli.Value = DateTime.Now;
            txtPemasok.Text = "";
            cmbBarang.SelectedIndex = -1;
            numJumlah.Value = 1;
            txtHargaSatuan.Text = "0";
        }

        private void LoadBarangKeComboBox()
        {
            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Menggunakan 'using' untuk koneksi ---
            // Ini otomatis menutup koneksi, bahkan jika terjadi error.
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Barang, Nama_Barang FROM tblBarang ORDER BY Nama_Barang";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmbBarang.DataSource = dt;
                    cmbBarang.DisplayMember = "Nama_Barang";
                    cmbBarang.ValueMember = "ID_Barang";
                }
                // --- PERBAIKAN: Notifikasi Profesional ---
                catch (Exception ex)
                {
                    // Jangan bocorkan 'ex.Message' ke pengguna
                    MessageBox.Show("Gagal memuat data barang. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup di sini.
        }

        private void TampilkanData()
        {
            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Menggunakan 'using' untuk koneksi ---
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.Tgl_Pembelian, p.No_Faktur, p.Nama_Pemasok, b.Nama_Barang, p.Jumlah, p.Harga_Satuan, pet.Nama_Lengkap AS [Petugas Pencatat]
                                     FROM tblPembelian p
                                     JOIN tblBarang b ON p.ID_Barang = b.ID_Barang
                                     JOIN tblPetugas pet ON p.ID_Petugas = pet.ID_Petugas
                                     ORDER BY p.Tgl_Pembelian DESC";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvPembelian.DataSource = dt;
                    dgvPembelian.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                // --- PERBAIKAN: Notifikasi Profesional ---
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan riwayat pembelian. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup di sini.
        }

        private string BuatSingkatan(string nama)
        {
            // (Logika BuatSingkatan Anda sudah oke, tidak perlu diubah)
            if (string.IsNullOrWhiteSpace(nama)) return "BRG";
            string[] parts = nama.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string singkatan = "";
            if (parts.Length >= 2)
            {
                singkatan = parts[0][0].ToString() + parts[1][0].ToString();
            }
            else if (parts.Length == 1)
            {
                singkatan = parts[0].Length > 1 ? parts[0].Substring(0, 2) : parts[0];
            }
            return singkatan.ToUpper();
        }

        // --- PERBAIKAN BESAR DI SINI (LOGIKA DAN EFISIENSI) ---
        private void GenerateNomorFaktur()
        {
            if (cmbBarang.SelectedIndex == -1 || cmbBarang.SelectedValue == null)
            {
                txtNoFaktur.Text = "(Pilih barang untuk generate kode)";
                return;
            }

            string namaBarang = cmbBarang.Text;
            string singkatan = BuatSingkatan(namaBarang);
            DateTime tanggal = dtpTanggalBeli.Value;

            string tgl_dd = tanggal.ToString("dd");
            string tgl_MM = tanggal.ToString("MM");
            string tgl_yyyy = tanggal.ToString("yyyy");

            // Format pencarian: KP/%/21/10/2025
            string pattern = $"{singkatan}/%/{tgl_dd}/{tgl_MM}/{tgl_yyyy}";
            int maxNoUrut = 0;

            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Menggunakan 'using' untuk koneksi ---
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // --- PERBAIKAN: Biarkan SQL Server yang mencari nilai MAX, bukan C# ---
                    // Ini jauh lebih cepat dan efisien daripada menarik semua data ke C#.
                    string query = @"
                        SELECT MAX(CAST(SUBSTRING(No_Faktur, 
                                     LEN(@singkatan) + 2, 
                                     CHARINDEX('/', No_Faktur, LEN(@singkatan) + 2) - (LEN(@singkatan) + 2)
                                   ) AS INT))
                        FROM tblPembelian 
                        WHERE No_Faktur LIKE @pattern";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@singkatan", singkatan);
                    cmd.Parameters.AddWithValue("@pattern", pattern);

                    object result = cmd.ExecuteScalar();

                    // Jika result bukan null (artinya ada data ditemukan), konversi ke int
                    if (result != DBNull.Value && result != null)
                    {
                        maxNoUrut = Convert.ToInt32(result);
                    }
                    // Jika result adalah DBNull.Value (tidak ada data), maxNoUrut tetap 0

                    int newNoUrut = maxNoUrut + 1;
                    txtNoFaktur.Text = $"{singkatan}/{newNoUrut:D2}/{tgl_dd}/{tgl_MM}/{tgl_yyyy}";
                }
                // --- PERBAIKAN: Notifikasi Profesional ---
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal generate nomor faktur. Hubungi administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoFaktur.Text = "Error!";
                }
            } // 'conn' otomatis ditutup di sini.
        }

        private void btnSimpanPembelian_Click(object sender, EventArgs e)
        {
            if (cmbBarang.SelectedIndex == -1 || numJumlah.Value <= 0)
            {
                MessageBox.Show("Harap pilih barang dan isi jumlah pembelian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHargaSatuan.Text, out decimal hargaSatuan) || hargaSatuan < 0)
            {
                MessageBox.Show("Format harga satuan tidak valid. Harap masukkan angka yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Menggunakan 'using' untuk koneksi ---
            using (SqlConnection conn = kon.GetConn())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Tambah stok di tblBarang
                    using (SqlCommand cmdUpdateStok = new SqlCommand("UPDATE tblBarang SET Stok = Stok + @jumlah WHERE ID_Barang = @idBarang", conn, transaction))
                    {
                        cmdUpdateStok.Parameters.AddWithValue("@jumlah", numJumlah.Value);
                        cmdUpdateStok.Parameters.AddWithValue("@idBarang", cmbBarang.SelectedValue);
                        cmdUpdateStok.ExecuteNonQuery();
                    }

                    // 2. Catat riwayat di tblPembelian
                    string queryInsert = @"INSERT INTO tblPembelian (No_Faktur, Tgl_Pembelian, Nama_Pemasok, ID_Barang, Jumlah, Harga_Satuan, ID_Petugas)
                                           VALUES (@faktur, @tgl, @pemasok, @idBarang, @jumlah, @harga, @idPetugas)";
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@faktur", txtNoFaktur.Text);
                        cmdInsert.Parameters.AddWithValue("@tgl", dtpTanggalBeli.Value);
                        cmdInsert.Parameters.AddWithValue("@pemasok", txtPemasok.Text.Trim()); // Gunakan .Trim()
                        cmdInsert.Parameters.AddWithValue("@idBarang", cmbBarang.SelectedValue);
                        cmdInsert.Parameters.AddWithValue("@jumlah", numJumlah.Value);
                        cmdInsert.Parameters.AddWithValue("@harga", hargaSatuan);
                        cmdInsert.Parameters.AddWithValue("@idPetugas", this.idPetugasPencatat);
                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Data pembelian berhasil disimpan dan stok telah diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                // --- PERBAIKAN: Notifikasi Profesional ---
                catch (SqlException sqlEx)
                {
                    if (transaction != null) transaction.Rollback();
                    string userMessage = "Gagal menyimpan data pembelian. ";

                    // Cek error spesifik dari SQL
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601) // Pelanggaran Primary Key (No_Faktur duplikat)
                    {
                        userMessage += "Nomor faktur ini sudah terdaftar. Coba ganti tanggal atau barang untuk generate ulang.";
                    }
                    else if (sqlEx.Number == 547) // Pelanggaran Foreign Key
                    {
                        userMessage += "Data barang atau petugas tidak valid.";
                    }
                    else
                    {
                        userMessage += "Terjadi masalah pada database.";
                    }
                    MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    // Error umum (bukan SQL)
                    MessageBox.Show("Gagal menyimpan data. Terjadi kesalahan sistem.", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup di sini

            KondisiAwal();
            TampilkanData();
            LoadBarangKeComboBox();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // --- PERBAIKAN: Keamanan RowFilter (mencegah injection) ---
                // Ganti tanda kutip tunggal dengan dua tanda kutip
                string filterText = txtCari.Text.Replace("'", "''");

                (dgvPembelian.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                    "No_Faktur LIKE '%{0}%' OR Nama_Pemasok LIKE '%{0}%' OR [Nama_Barang] LIKE '%{0}%'", filterText);
            }
            // --- PERBAIKAN: Jangan "telan" error ---
            catch (Exception ex)
            {
                // Tampilkan error di output window saat debugging
                System.Diagnostics.Debug.WriteLine("Filter error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Event handler untuk generate No. Faktur ---
        private void cmbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateNomorFaktur();
        }

        private void dtpTanggalBeli_ValueChanged(object sender, EventArgs e)
        {
            GenerateNomorFaktur();
        }

        // --- Metode Helper (sudah bagus) ---
        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyPembelianChanged();
        }

        public void ReloadBarangComboBox()
        {
            object selectedValue = cmbBarang.SelectedValue;
            LoadBarangKeComboBox();
            if (selectedValue != null) cmbBarang.SelectedValue = selectedValue;
            if (cmbBarang.SelectedIndex == -1) GenerateNomorFaktur();
        }
        public void RefreshRiwayatPembelian() { TampilkanData(); }
    }
}