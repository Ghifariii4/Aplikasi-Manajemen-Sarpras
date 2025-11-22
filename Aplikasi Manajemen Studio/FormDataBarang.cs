using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Text; // Dibutuhkan untuk Ekspor yang lebih baik

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormDataBarang : Form
    {
        private string mode;
        private string idBarangTerpilih;
        private string userJabatan;

        public FormDataBarang(string jabatan)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            txtKodeBarang.Enabled = false;
            this.userJabatan = jabatan;

            cmbSatuan.DataSource = daftarSatuan;
        }

        private string GenerateKodeBarang()
        {
            string prefix = "BRG";
            string tanggal = DateTime.Now.ToString("yyMMdd");
            string kodeBaru = "";
            int nomorUrut = 1;

            Koneksi kon = new Koneksi();
            // Gunakan 'using' untuk memastikan koneksi ditutup
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT TOP 1 Kode_Barang FROM tblBarang WHERE Kode_Barang LIKE @prefix ORDER BY Kode_Barang DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Gunakan parameter untuk keamanan dan kejelasan
                    cmd.Parameters.AddWithValue("@prefix", $"{prefix}-{tanggal}-%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string kodeTerakhir = reader["Kode_Barang"].ToString();
                            string nomorUrutTerakhirString = kodeTerakhir.Substring(kodeTerakhir.Length - 4);
                            int.TryParse(nomorUrutTerakhirString, out int nomorUrutTerakhir);
                            nomorUrut = nomorUrutTerakhir + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat kode barang otomatis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'using' otomatis menutup koneksi di sini

            kodeBaru = $"{prefix}-{tanggal}-{nomorUrut:D4}";
            return kodeBaru;
        }

        private List<string> daftarSatuan = new List<string>()
        {
            "Pcs", "Unit", "Buah", "Set", "Box", "Pack", "Lusin", "Rim", "Botol", "Roll"
        };

        // --- Metode untuk Mengatur Kondisi Form ---

        private void KondisiAwal()
        {
            BersihkanInput();
            InputFields(false);

            btnTambah.Text = "Tambah";
            btnUbah.Text = "Ubah";

            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;

            mode = "";
        }

        private void BersihkanInput()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            cmbSatuan.SelectedIndex = -1;
            numStok.Value = 0;
            txtKeterangan.Text = ""; // <--- BARU
            idBarangTerpilih = null;
        }

        private void InputFields(bool isEnabled)
        {
            txtNamaBarang.Enabled = isEnabled;
            cmbSatuan.Enabled = isEnabled;
            numStok.Enabled = isEnabled;
            txtKeterangan.Enabled = isEnabled; // <--- BARU
        }

        // --- Metode untuk Menampilkan Data ---

        private void TampilkanData()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // --- UBAH DI SINI ---
                    // Ambil kolom 'TanggalDibuat' dan 'TanggalDiubah'
                    SqlCommand cmd = new SqlCommand("SELECT ID_Barang, Kode_Barang, Nama_Barang, Satuan, Stok, Keterangan, TanggalDibuat, TanggalDiubah FROM tblBarang", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvBarang.DataSource = dt;

                    // ... (Kode header Anda yang sudah ada) ...
                    dgvBarang.Columns["ID_Barang"].HeaderText = "ID";
                    dgvBarang.Columns["Kode_Barang"].HeaderText = "Kode Barang";
                    dgvBarang.Columns["Nama_Barang"].HeaderText = "Nama Barang";
                    dgvBarang.Columns["Satuan"].HeaderText = "Satuan";
                    dgvBarang.Columns["Stok"].HeaderText = "Stok";
                    dgvBarang.Columns["Keterangan"].HeaderText = "Keterangan";

                    // --- TAMBAHKAN INI ---
                    // Atur header dan format untuk kolom baru
                    dgvBarang.Columns["TanggalDibuat"].HeaderText = "Tgl. Dibuat";
                    dgvBarang.Columns["TanggalDiubah"].HeaderText = "Tgl. Diubah";

                    // Atur format tampilan tanggal (Opsional tapi sangat disarankan)
                    dgvBarang.Columns["TanggalDibuat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvBarang.Columns["TanggalDiubah"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    // ---------------------

                    dgvBarang.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvBarang.Columns["Keterangan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Event Handler ---

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            TampilkanData();
            KondisiAwal();

            if (userJabatan != "Kepala Sarpras")
            {
                btnTambah.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnBatal.Visible = false;
            }
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBarang.Rows[e.RowIndex];

                idBarangTerpilih = row.Cells["ID_Barang"].Value.ToString();
                txtKodeBarang.Text = row.Cells["Kode_Barang"].Value.ToString();
                txtNamaBarang.Text = row.Cells["Nama_Barang"].Value.ToString();
                cmbSatuan.SelectedItem = row.Cells["Satuan"].Value.ToString();
                numStok.Value = Convert.ToDecimal(row.Cells["Stok"].Value);

                // --- BARU: Tampilkan Keterangan ---
                // Gunakan Cek DBNull untuk menghindari error jika data di database NULL
                txtKeterangan.Text = row.Cells["Keterangan"].Value == DBNull.Value ? "" : row.Cells["Keterangan"].Value.ToString();

                InputFields(false);
                btnTambah.Text = "Tambah";
                btnUbah.Text = "Ubah";
                btnTambah.Enabled = true;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
                btnBatal.Enabled = true;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                mode = "tambah";
                BersihkanInput();
                InputFields(true);

                txtKodeBarang.Text = GenerateKodeBarang();
                txtKodeBarang.Enabled = false;

                btnTambah.Text = "Simpan";
                btnUbah.Enabled = false;
                btnHapus.Enabled = false;
                btnBatal.Enabled = true;
                txtNamaBarang.Focus();
            }
            else // Jika teks tombol adalah "Simpan" (dari mode Tambah)
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtNamaBarang.Text) || cmbSatuan.SelectedIndex == -1)
                {
                    MessageBox.Show("Nama Barang dan Satuan harus diisi.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaBarang = txtNamaBarang.Text.Trim();

                Koneksi kon = new Koneksi();
                using (SqlConnection conn = kon.GetConn())
                {
                    try
                    {
                        conn.Open();

                        // --- FITUR 1: Validasi Nama Duplikat ---
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM tblBarang WHERE Nama_Barang = @nama", conn);
                        checkCmd.Parameters.AddWithValue("@nama", namaBarang);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Nama barang ini sudah terdaftar. Silakan gunakan nama lain.",
                                            "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNamaBarang.Focus();
                            return; // Hentikan proses simpan
                        }

                        // --- UBAH DI SINI ---
                        string query = "INSERT INTO tblBarang (Kode_Barang, Nama_Barang, Satuan, Stok, Keterangan, TanggalDibuat, TanggalDiubah) VALUES (@kode, @nama, @satuan, @stok, @keterangan, @tglDibuat, @tglDiubah)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@kode", txtKodeBarang.Text);
                        cmd.Parameters.AddWithValue("@nama", namaBarang);
                        cmd.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@stok", numStok.Value);
                        cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);

                        // --- TAMBAHKAN INI ---
                        // Set kedua tanggal ke waktu sekarang saat dibuat
                        cmd.Parameters.AddWithValue("@tglDibuat", DateTime.Now);
                        cmd.Parameters.AddWithValue("@tglDiubah", DateTime.Now);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data barang baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotifyParentForm();
                    }
                    // --- PERBAIKAN: Notifikasi Error Profesional ---
                    catch (SqlException sqlEx)
                    {
                        string userMessage = "Gagal menambahkan data. ";
                        if (sqlEx.Number == 8152) // Data terlalu panjang
                            userMessage += "Data yang Anda masukkan terlalu panjang.";
                        else
                            userMessage += "Terjadi masalah pada database. Silakan hubungi administrator.";

                        MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan sistem yang tidak terduga.",
                                        "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                } // 'using' otomatis menutup koneksi

                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (btnUbah.Text == "Ubah")
            {
                if (idBarangTerpilih == null)
                {
                    MessageBox.Show("Silakan pilih data yang ingin diubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mode = "ubah";
                InputFields(true);
                btnUbah.Text = "Simpan";
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                btnBatal.Enabled = true;
                txtNamaBarang.Focus(); // <-- PERBAIKAN (sebelumnya txtKodeBarang.Focus() yg nonaktif)
            }
            else // Jika teks tombol adalah "Simpan" (dari mode Ubah)
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtNamaBarang.Text) || cmbSatuan.SelectedIndex == -1)
                {
                    MessageBox.Show("Nama Barang dan Satuan harus diisi.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaBarang = txtNamaBarang.Text.Trim();

                Koneksi kon = new Koneksi();
                using (SqlConnection conn = kon.GetConn())
                {
                    try
                    {
                        conn.Open();

                        // --- FITUR 1: Validasi Nama Duplikat (saat Ubah) ---
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM tblBarang WHERE Nama_Barang = @nama AND ID_Barang != @id", conn);
                        checkCmd.Parameters.AddWithValue("@nama", namaBarang);
                        checkCmd.Parameters.AddWithValue("@id", idBarangTerpilih); // ID barang yg sedang diedit
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Nama barang ini sudah terdaftar untuk item lain.",
                                            "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNamaBarang.Focus();
                            return;
                        }

                        // --- UBAH DI SINI ---
                        // 'TanggalDibuat' TIDAK di-update
                        string query = "UPDATE tblBarang SET Nama_Barang = @nama, Satuan = @satuan, Stok = @stok, Keterangan = @keterangan, TanggalDiubah = @tglDiubah WHERE ID_Barang = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nama", namaBarang);
                        cmd.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@stok", numStok.Value);
                        cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);
                        cmd.Parameters.AddWithValue("@id", idBarangTerpilih);

                        // --- TAMBAHKAN INI ---
                        // Set HANYA 'TanggalDiubah' ke waktu sekarang
                        cmd.Parameters.AddWithValue("@tglDiubah", DateTime.Now);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotifyParentForm();
                    }
                    // --- PERBAIKAN: Notifikasi Error Profesional ---
                    catch (SqlException sqlEx)
                    {
                        string userMessage = "Gagal mengubah data. ";
                        if (sqlEx.Number == 8152) // Data terlalu panjang
                            userMessage += "Data yang Anda masukkan terlalu panjang.";
                        else
                            userMessage += "Terjadi masalah pada database. Silakan hubungi administrator.";

                        MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan sistem yang tidak terduga.",
                                        "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                } // 'using' otomatis menutup koneksi

                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idBarangTerpilih != null)
            {
                if (MessageBox.Show("Anda yakin ingin menghapus data '" + txtNamaBarang.Text + "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    using (SqlConnection conn = kon.GetConn())
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM tblBarang WHERE ID_Barang = @id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", idBarangTerpilih);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NotifyParentForm();
                        }
                        // --- PERBAIKAN: Notifikasi Error Profesional ---
                        catch (SqlException sqlEx)
                        {
                            string userMessage = "Gagal menghapus data. ";
                            if (sqlEx.Number == 547) // Foreign Key constraint
                                userMessage += "Barang ini tidak dapat dihapus karena sedang digunakan di data lain (misal: data peminjaman).";
                            else
                                userMessage += "Terjadi masalah pada database.";

                            MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan sistem yang tidak terduga.",
                                            "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    } // 'using' otomatis menutup koneksi

                    TampilkanData();
                    KondisiAwal();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dgvBarang.DataSource as DataTable;
                if (dt != null)
                {
                    // Gunakan Trim() dan Replace() untuk keamanan RowFilter
                    string filterText = txtCari.Text.Trim().Replace("'", "''");
                    // --- PERBAIKAN: Filter juga kolom Keterangan ---
                    dt.DefaultView.RowFilter = string.Format(
                        "Kode_Barang LIKE '%{0}%' OR Nama_Barang LIKE '%{0}%' OR Keterangan LIKE '%{0}%'",
                        filterText
                    );
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Filter error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- LOGIKA IMPOR DAN EKSPOR (DIPERBARUI) ---

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            // Peringatan ini bagus, tapi mari kita buat ekspornya lebih tangguh
            // dengan mengapit nilai dalam tanda kutip.

            if (dgvBarang.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Asumsikan Anda punya saveFileDialog1 di form
            saveFileDialog1.Filter = "CSV File (*.csv)|*.csv";
            saveFileDialog1.FileName = $"Data_Barang_{DateTime.Now:yyyyMMdd}.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog1.FileName;
                    StringBuilder sb = new StringBuilder();

                    // --- UBAH DI SINI ---
                    sb.AppendLine("\"Kode_Barang\",\"Nama_Barang\",\"Satuan\",\"Stok\",\"Keterangan\",\"TanggalDibuat\",\"TanggalDiubah\"");

                    DataTable dt = (DataTable)dgvBarang.DataSource;

                    foreach (DataRow row in dt.Rows)
                    {
                        Func<object, string> cleanCsv = val =>
                            $"\"{(val ?? "").ToString().Replace("\"", "\"\"")}\"";

                        // --- UBAH DI SINI ---
                        sb.AppendLine(string.Join(",",
                            cleanCsv(row["Kode_Barang"]),
                            cleanCsv(row["Nama_Barang"]),
                            cleanCsv(row["Satuan"]),
                            cleanCsv(row["Stok"]),
                            cleanCsv(row["Keterangan"]),
                            cleanCsv(row["TanggalDibuat"]), // <--- BARU
                            cleanCsv(row["TanggalDiubah"])  // <--- BARU
                        ));
                    }

                    File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImpor_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "PERINGATAN!\n\nProses impor ini akan MENGHAPUS SEMUA data barang yang ada dan menggantinya dengan data dari file CSV.\n\nApakah Anda yakin ingin melanjutkan?",
                "Konfirmasi Impor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.No) return;

            // Asumsikan Anda punya openFileDialog1 di form
            openFileDialog1.Filter = "CSV File (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                SqlTransaction transaction = null;
                int baris = 1;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Hapus semua data lama
                    using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM tblBarang", conn, transaction))
                    {
                        cmdDelete.ExecuteNonQuery();
                    }
                    // Reset ID (Opsional tapi disarankan)
                    using (SqlCommand cmdReset = new SqlCommand("DBCC CHECKIDENT ('tblBarang', RESEED, 0)", conn, transaction))
                    {
                        cmdReset.ExecuteNonQuery();
                    }

                    // 2. Baca file dan masukkan data baru
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string headerLine = sr.ReadLine()?.ToLower()?.Replace("\"", "");
                        // --- BARU: Cek 5 Kolom ---
                        if (headerLine != "kode_barang,nama_barang,satuan,stok,keterangan")
                        {
                            throw new Exception("Format header file CSV tidak sesuai. Harap gunakan 5 kolom: Kode_Barang,Nama_Barang,Satuan,Stok,Keterangan");
                        }

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            baris++;
                            // Ini parsing CSV sederhana, tidak bisa menangani koma di dalam tanda kutip
                            string[] fields = line.Split(',');

                            // --- BARU: Cek 5 Kolom ---
                            if (fields.Length != 5)
                            {
                                throw new Exception($"Format data salah di baris {baris}. Diharapkan 5 kolom.");
                            }

                            // Fungsi untuk "membersihkan" nilai dari CSV
                            Func<string, string> unCleanCsv = val =>
                                val.Trim().TrimStart('\"').TrimEnd('\"').Replace("\"\"", "\"");

                            string queryInsert = "INSERT INTO tblBarang (Kode_Barang, Nama_Barang, Satuan, Stok, Keterangan) VALUES (@kode, @nama, @satuan, @stok, @keterangan)";
                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                            {
                                cmdInsert.Parameters.AddWithValue("@kode", unCleanCsv(fields[0]));
                                cmdInsert.Parameters.AddWithValue("@nama", unCleanCsv(fields[1]));
                                cmdInsert.Parameters.AddWithValue("@satuan", unCleanCsv(fields[2]));
                                if (!int.TryParse(unCleanCsv(fields[3]), out int stok))
                                {
                                    throw new Exception($"Nilai 'Stok' ({fields[3]}) di baris {baris} bukan angka.");
                                }
                                cmdInsert.Parameters.AddWithValue("@stok", stok);
                                cmdInsert.Parameters.AddWithValue("@keterangan", unCleanCsv(fields[4])); // <--- BARU
                                cmdInsert.Parameters.AddWithValue("@tglDibuat", DateTime.Now);
                                cmdInsert.Parameters.AddWithValue("@tglDiubah", DateTime.Now);

                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show($"Data berhasil diimpor! ({baris - 1} baris data diproses)", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show($"Impor GAGAL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }

                TampilkanData();
                KondisiAwal();
            }
        }

        // Metode helper (tidak berubah)
        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataBarangChanged();
        }

        public void RefreshGridData() { TampilkanData(); }

    }
}