using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio // Sesuaikan dengan namespace Anda
{
    public partial class FormDataSiswa : Form
    {
        private string mode;
        private string idSiswaTerpilih;
        private string userJabatan;

        public FormDataSiswa(string jabatan)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.userJabatan = jabatan;
        }

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
            txtNisn.Text = "";
            txtNamaSiswa.Text = "";
            cmbKelas.SelectedIndex = -1; // Kosongkan pilihan ComboBox
            idSiswaTerpilih = null;
        }

        private void InputFields(bool isEnabled)
        {
            txtNisn.Enabled = isEnabled;
            txtNamaSiswa.Enabled = isEnabled;
            cmbKelas.Enabled = isEnabled;
        }

        // --- Metode untuk Mengisi ComboBox dan Menampilkan Data ---

        private void LoadKelasKeComboBox()
        {
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Kelas, Nama_Kelas FROM tblKelas ORDER BY Nama_Kelas", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cmbKelas.DataSource = dt;
                cmbKelas.DisplayMember = "Nama_Kelas"; // Yang ditampilkan ke user
                cmbKelas.ValueMember = "ID_Kelas";   // Nilai yang disimpan (ID)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kelas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void TampilkanData()
        {
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                // Menggunakan JOIN untuk mengambil Nama_Kelas, bukan hanya ID_Kelas
                string query = @"SELECT s.ID_Siswa, s.NISN, s.Nama_Siswa, k.Nama_Kelas 
                                 FROM tblSiswa s 
                                 JOIN tblKelas k ON s.ID_Kelas = k.ID_Kelas";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvSiswa.DataSource = dt;

                // Mengatur header kolom
                dgvSiswa.Columns["ID_Siswa"].HeaderText = "ID";
                dgvSiswa.Columns["NISN"].HeaderText = "NISN";
                dgvSiswa.Columns["Nama_Siswa"].HeaderText = "Nama Siswa";
                dgvSiswa.Columns["Nama_Kelas"].HeaderText = "Kelas";
                dgvSiswa.Columns["Nama_Siswa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // --- Event Handler ---

        private void FormDataSiswa_Load(object sender, EventArgs e)
        {

            // Mengisi ComboBox filter tingkat
            cmbFilterTingkat.Items.Clear();
            cmbFilterTingkat.Items.Add("Semua Tingkat");    
                
                                                
            cmbFilterTingkat.Items.Add("Kelas X");
            cmbFilterTingkat.Items.Add("Kelas XI");
            cmbFilterTingkat.Items.Add("Kelas XII");
            cmbFilterTingkat.SelectedIndex = 0;


            LoadKelasKeComboBox(); // Pertama, isi dulu ComboBox
            TampilkanData();       // Kemudian, tampilkan data siswa
            KondisiAwal();

            if (userJabatan != "Kepala Sarpras")
            {
                btnTambah.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnBatal.Visible = false;
            }
        }

        private void dgvSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mode == "")
            {
                DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];
                idSiswaTerpilih = row.Cells["ID_Siswa"].Value.ToString();
                txtNisn.Text = row.Cells["NISN"].Value.ToString();
                txtNamaSiswa.Text = row.Cells["Nama_Siswa"].Value.ToString();

                // Set ComboBox sesuai dengan nama kelas dari baris yang dipilih
                cmbKelas.Text = row.Cells["Nama_Kelas"].Value.ToString();

                InputFields(false);
                btnTambah.Text = "Tambah";
                btnUbah.Text = "Ubah";
                btnTambah.Enabled = true;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
                btnBatal.Enabled = true;
            }
        }

        /// <summary>
        /// Menerapkan filter gabungan dari kotak pencarian dan dropdown tingkat.
        /// </summary>
        private void ApplyFilter()
        {
            DataTable dt = dgvSiswa.DataSource as DataTable;
            if (dt == null) return; // Jika data belum ter-load, hentikan

            // List untuk menampung semua kondisi filter
            var filterConditions = new List<string>();

            // --- Filter 1: Dari txtCari (Pencarian Teks) ---
            string searchText = txtCari.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(searchText))
            {
                // Filter berdasarkan NISN, Nama_Siswa, atau Nama_Kelas
                filterConditions.Add(string.Format(
                    "(NISN LIKE '%{0}%' OR Nama_Siswa LIKE '%{0}%' OR Nama_Kelas LIKE '%{0}%')",
                    searchText
                ));
            }

            // --- Filter 2: Dari cmbFilterTingkat (Filter Tingkat) ---
            if (cmbFilterTingkat.SelectedIndex > 0) // (Index 0 adalah "Semua Tingkat")
            {
                string selectedTingkat = cmbFilterTingkat.SelectedItem.ToString();
                string tingkatValue = "";

                if (selectedTingkat == "Kelas X")
                {
                    tingkatValue = "X "; // <--- WAJIB PAKAI SPASI
                }
                else if (selectedTingkat == "Kelas XI")
                {
                    tingkatValue = "XI "; // <--- WAJIB PAKAI SPASI
                }
                else if (selectedTingkat == "Kelas XII")
                {
                    tingkatValue = "XII "; // <--- WAJIB PAKAI SPASI
                }

                // Dan pastikan baris ini sudah benar menggunakan Nama_Kelas (bukan 'Kelas')
                filterConditions.Add(string.Format("Nama_Kelas LIKE '{0}%'", tingkatValue));
            }

            // --- Gabungkan Semua Filter ---
            try
            {
                // Menggabungkan semua kondisi dengan "AND"
                dt.DefaultView.RowFilter = string.Join(" AND ", filterConditions);
            }
            catch (Exception ex)
            {
                // (Seperti sebelumnya, ini untuk debugging jika filter error)
                System.Diagnostics.Debug.WriteLine("Filter error: " + ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                mode = "tambah";
                BersihkanInput();
                InputFields(true);
                btnTambah.Text = "Simpan";
                btnUbah.Enabled = false;
                btnHapus.Enabled = false;
                btnBatal.Enabled = true;
                txtNisn.Focus();
            }
            else if (btnTambah.Text == "Simpan" && mode == "tambah")
            {
                // --- Validasi 1: Input Kosong ---
                if (string.IsNullOrWhiteSpace(txtNisn.Text) || string.IsNullOrWhiteSpace(txtNamaSiswa.Text) || cmbKelas.SelectedIndex == -1)
                {
                    MessageBox.Show("Semua kolom (NISN, Nama Siswa, dan Kelas) harus diisi.",
                                    "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nisn = txtNisn.Text.Trim(); // .Trim() untuk hapus spasi
                string nama = txtNamaSiswa.Text.Trim();

                Koneksi kon = new Koneksi();
                // Gunakan 'using' agar koneksi otomatis ditutup, bahkan saat terjadi error
                using (SqlConnection conn = kon.GetConn())
                {
                    try
                    {
                        conn.Open();

                        // --- Validasi 2: Duplikat NISN ---
                        // Cek apakah NISN sudah ada di database
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM tblSiswa WHERE NISN = @nisn", conn);
                        checkCmd.Parameters.AddWithValue("@nisn", nisn);

                        // ExecuteScalar digunakan untuk mengambil 1 nilai saja (jumlah)
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("NISN ini sudah terdaftar untuk siswa lain. \nSilakan gunakan NISN yang berbeda.",
                                            "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNisn.Focus(); // Fokuskan kembali ke textbox NISN
                            return; // Hentikan proses simpan
                        }

                        // --- Proses Insert (Jika Lolos Semua Validasi) ---
                        string query = "INSERT INTO tblSiswa (NISN, Nama_Siswa, ID_Kelas) VALUES (@nisn, @nama, @id_kelas)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nisn", nisn);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@id_kelas", cmbKelas.SelectedValue);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data siswa baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotifyParentForm();
                    }
                    // --- Penanganan Error Profesional ---
                    catch (SqlException sqlEx)
                    {
                        // Tangkap error spesifik dari SQL
                        string userMessage = "Gagal menambahkan data siswa. ";
                        switch (sqlEx.Number)
                        {
                            case 8152: // Error: Data terlalu panjang
                                userMessage += "Data yang Anda masukkan terlalu panjang untuk salah satu kolom.";
                                break;
                            case 547: // Error: Foreign Key (misal ID_Kelas tidak ada)
                                userMessage += "Kelas yang dipilih sepertinya tidak valid.";
                                break;
                            default: // Error SQL lainnya
                                userMessage += "Terjadi masalah pada database. Silakan hubungi administrator.";
                                break;
                        }
                        MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Tangkap error umum (bukan dari SQL)
                        MessageBox.Show("Terjadi kesalahan yang tidak terduga. \nSilakan hubungi administrator.",
                                        "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        // (Opsional: Anda bisa log ex.Message ke file untuk debugging)
                    }
                } // 'using' akan otomatis conn.Close() di sini

                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (btnUbah.Text == "Ubah")
            {
                if (idSiswaTerpilih == null)
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
                txtNisn.Focus();
            }
            else if (btnUbah.Text == "Simpan" && mode == "ubah")
            {
                // --- Validasi 1: Input Kosong ---
                if (string.IsNullOrWhiteSpace(txtNisn.Text) || string.IsNullOrWhiteSpace(txtNamaSiswa.Text) || cmbKelas.SelectedIndex == -1)
                {
                    MessageBox.Show("Semua kolom (NISN, Nama Siswa, dan Kelas) harus diisi.",
                                    "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nisn = txtNisn.Text.Trim();
                string nama = txtNamaSiswa.Text.Trim();

                Koneksi kon = new Koneksi();
                using (SqlConnection conn = kon.GetConn())
                {
                    try
                    {
                        conn.Open();

                        // --- Validasi 2: Duplikat NISN (saat Ubah) ---
                        // Cek apakah NISN ini sudah dipakai oleh siswa LAIN
                        // Kita kecualikan ID_Siswa yang sedang kita edit
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM tblSiswa WHERE NISN = @nisn AND ID_Siswa != @id", conn);
                        checkCmd.Parameters.AddWithValue("@nisn", nisn);
                        checkCmd.Parameters.AddWithValue("@id", idSiswaTerpilih); // ID siswa yang sedang diedit

                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("NISN ini sudah terdaftar untuk siswa lain. \nSilakan gunakan NISN yang berbeda.",
                                            "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNisn.Focus();
                            return; // Hentikan proses simpan
                        }

                        // --- Proses Update (Jika Lolos Semua Validasi) ---
                        string query = "UPDATE tblSiswa SET NISN = @nisn, Nama_Siswa = @nama, ID_Kelas = @id_kelas WHERE ID_Siswa = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nisn", nisn);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@id_kelas", cmbKelas.SelectedValue);
                        cmd.Parameters.AddWithValue("@id", idSiswaTerpilih);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data siswa berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotifyParentForm();
                    }
                    // --- Penanganan Error Profesional ---
                    catch (SqlException sqlEx)
                    {
                        string userMessage = "Gagal mengubah data siswa. ";
                        switch (sqlEx.Number)
                        {
                            case 8152:
                                userMessage += "Data yang Anda masukkan terlalu panjang untuk salah satu kolom.";
                                break;
                            case 547:
                                userMessage += "Kelas yang dipilih sepertinya tidak valid.";
                                break;
                            default:
                                userMessage += "Terjadi masalah pada database. Silakan hubungi administrator.";
                                break;
                        }
                        MessageBox.Show(userMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan yang tidak terduga. \nSilakan hubungi administrator.",
                                        "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                } // 'using' akan otomatis conn.Close()

                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idSiswaTerpilih != null)
            {
                if (MessageBox.Show($"Anda yakin ingin menghapus data siswa '{txtNamaSiswa.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    SqlConnection conn = kon.GetConn();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblSiswa WHERE ID_Siswa = @id", conn);
                        cmd.Parameters.AddWithValue("@id", idSiswaTerpilih);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotifyParentForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
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
            ApplyFilter();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFilterTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Panggil metode filter gabungan yang sama
            ApplyFilter();
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvSiswa.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"Data_Siswa_{DateTime.Now:yyyyMMdd}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    var headers = dgvSiswa.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => $"\"{column.HeaderText}\"").ToArray()));

                    foreach (DataGridViewRow row in dgvSiswa.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => $"\"{cell.Value}\"").ToArray()));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data siswa berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnImpor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File (*.csv)|*.csv";
            ofd.Title = "Pilih file CSV untuk diimpor (Siswa)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var barisGagal = new List<string>();
                int barisBerhasil = 0;

                var petaKelas = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                Koneksi kon = new Koneksi();
                using (SqlConnection conn = kon.GetConn())
                {
                    await conn.OpenAsync();
                    SqlCommand cmdKelas = new SqlCommand("SELECT Nama_Kelas, ID_Kelas FROM tblKelas", conn);
                    using (SqlDataReader reader = await cmdKelas.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            petaKelas[reader["Nama_Kelas"].ToString().Trim()] = (int)reader["ID_Kelas"];
                        }
                    }
                }

                var lines = File.ReadAllLines(ofd.FileName).Skip(1);
                using (SqlConnection conn = kon.GetConn())
                {
                    await conn.OpenAsync();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (string line in lines)
                        {
                            var columns = line.Split(',');
                            if (columns.Length != 3) // NISN, Nama_Siswa, Nama_Kelas
                            {
                                barisGagal.Add($"Format salah (3 kolom diharapkan): {line}");
                                continue;
                            }

                            string nisn = columns[0].Trim();
                            string namaSiswa = columns[1].Trim();
                            string namaKelas = columns[2].Trim();

                            if (string.IsNullOrEmpty(nisn) || string.IsNullOrEmpty(namaSiswa) || string.IsNullOrEmpty(namaKelas))
                            {
                                barisGagal.Add($"Data tidak lengkap: {line}");
                                continue;
                            }

                            if (!petaKelas.TryGetValue(namaKelas, out int idKelas))
                            {
                                barisGagal.Add($"Kelas '{namaKelas}' tidak ditemukan: {line}");
                                continue;
                            }

                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblSiswa WHERE NISN = @nisn", conn, transaction);
                            checkCmd.Parameters.AddWithValue("@nisn", nisn);
                            if ((int)await checkCmd.ExecuteScalarAsync() > 0)
                            {
                                barisGagal.Add($"NISN '{nisn}' sudah ada: {line}");
                                continue;
                            }

                            string query = "INSERT INTO tblSiswa (NISN, Nama_Siswa, ID_Kelas) VALUES (@nisn, @nama, @id_kelas)";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@nisn", nisn);
                            cmd.Parameters.AddWithValue("@nama", namaSiswa);
                            cmd.Parameters.AddWithValue("@id_kelas", idKelas);
                            await cmd.ExecuteNonQueryAsync();
                            barisBerhasil++;
                        }

                        transaction.Commit();
                        MessageBox.Show($"Impor Selesai!\nBerhasil: {barisBerhasil}\nGagal: {barisGagal.Count}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (barisGagal.Any())
                        {
                            MessageBox.Show("Detail baris yang gagal:\n" + string.Join("\n", barisGagal), "Laporan Error");
                        }
                        NotifyParentForm();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null) transaction.Rollback();
                        MessageBox.Show("Terjadi error, semua data dibatalkan: " + ex.Message, "Impor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                TampilkanData();
            }
        }

        // Tambahkan metode helper ini
        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataSiswaChanged();
        }

        // Tambahkan metode public ini untuk menerima notifikasi
        public void ReloadKelasComboBox()
        {
            object selectedValue = cmbKelas.SelectedValue;
            LoadKelasKeComboBox();
            if (selectedValue != null) cmbKelas.SelectedValue = selectedValue;
        }
        public void RefreshGridData()
        {
            TampilkanData();
        }
    }
}