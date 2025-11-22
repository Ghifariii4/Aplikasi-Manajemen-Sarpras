using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aplikasi_Manajemen_Studio // Sesuaikan dengan namespace Anda
{
    public partial class FormDataPetugas : Form
    {
        private string mode;
        private string idPetugasTerpilih;
        private string userJabatan;

        public FormDataPetugas(string jabatan)
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
            txtNamaLengkap.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbJabatan.SelectedIndex = -1;
            idPetugasTerpilih = null;
        }

        private void InputFields(bool isEnabled)
        {
            txtNamaLengkap.Enabled = isEnabled;
            txtUsername.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            cmbJabatan.Enabled = isEnabled;
        }

        // --- Metode untuk Menampilkan Data ---

        private void TampilkanData()
        {
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                // PENTING: Jangan pernah mengambil kolom Password untuk ditampilkan di DataGridView
                SqlCommand cmd = new SqlCommand("SELECT ID_Petugas, Nama_Lengkap, Username, Jabatan FROM tblPetugas", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvPetugas.DataSource = dt;

                dgvPetugas.Columns["ID_Petugas"].HeaderText = "ID";
                dgvPetugas.Columns["Nama_Lengkap"].HeaderText = "Nama Lengkap";
                dgvPetugas.Columns["Username"].HeaderText = "Username";
                dgvPetugas.Columns["Jabatan"].HeaderText = "Jabatan";
                dgvPetugas.Columns["Nama_Lengkap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data petugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public static readonly string[] daftarJabatanPetugas = new string[]
        {
            "Kepala Sarpras",
            "Staff"
        };

        // --- Event Handler ---

        private void FormDataPetugas_Load(object sender, EventArgs e)
        {

            // --- TAMBAHKAN INI ---
            // Isi ComboBox Jabatan
            cmbJabatan.DataSource = daftarJabatanPetugas;
            cmbJabatan.DropDownStyle = ComboBoxStyle.DropDownList; // Pastikan hanya bisa dipilih
                                                                   // ---------------------

            TampilkanData();
            KondisiAwal();
            // Jangan tampilkan tombol CRUD jika bukan Kepala Sarpras (Anda sudah punya ini)
            if (userJabatan != "Kepala Sarpras")
            {
                btnTambah.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnBatal.Visible = false;
                // Tambahkan tombol Impor/Ekspor jika ada
                // btnImpor.Visible = false;
                // btnEkspor.Visible = false;
            }
        }

        private void dgvPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mode == "")
            {
                DataGridViewRow row = dgvPetugas.Rows[e.RowIndex];
                idPetugasTerpilih = row.Cells["ID_Petugas"].Value.ToString();
                txtNamaLengkap.Text = row.Cells["Nama_Lengkap"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                string jabatanDariGrid = row.Cells["Jabatan"].Value.ToString();
                txtPassword.Text = "";

                if (daftarJabatanPetugas.Contains(jabatanDariGrid))
                {
                    cmbJabatan.SelectedItem = jabatanDariGrid;
                }
                else
                {
                    cmbJabatan.SelectedIndex = -1; // Jika tidak ditemukan, kosongkan pilihan
                }

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
                btnTambah.Text = "Simpan";
                btnUbah.Enabled = false;
                btnHapus.Enabled = false;
                btnBatal.Enabled = true;
                txtNamaLengkap.Focus();
            }
            else if (btnTambah.Text == "Simpan" && mode == "tambah")
            {
                // --- TAMBAHKAN VALIDASI COMBOBOX ---
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbJabatan.SelectedItem == null) // <-- Tambahkan ini
                {
                    MessageBox.Show("Nama Lengkap, Username, Password, dan Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ------------------------------------

                string jabatanDipilih = cmbJabatan.SelectedItem.ToString();

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();

                    // --- TAMBAHKAN CEK ADMIN KEDUA ---
                    if (jabatanDipilih == "Kepala Sarpras")
                    {
                        string queryCekAdmin = "SELECT COUNT(*) FROM tblPetugas WHERE Jabatan = @jabatanAdmin";
                        using (SqlCommand cmdCekAdmin = new SqlCommand(queryCekAdmin, conn))
                        {
                            cmdCekAdmin.Parameters.AddWithValue("@jabatanAdmin", "Kepala Sarpras");
                            int adminExists = (int)cmdCekAdmin.ExecuteScalar();
                            if (adminExists > 0)
                            {
                                MessageBox.Show("Penambahan gagal. Hanya boleh ada satu 'Kepala Sarpras'.", "Aturan Bisnis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Hentikan proses
                            }
                        }
                    }
                    // --- CEK DUPLIKAT USERNAME (Anda mungkin sudah punya ini) ---
                    string queryCheckUser = "SELECT COUNT(*) FROM tblPetugas WHERE Username = @username";
                    using (SqlCommand cmdCheckUser = new SqlCommand(queryCheckUser, conn))
                    {
                        cmdCheckUser.Parameters.AddWithValue("@username", txtUsername.Text);
                        int userExists = (int)cmdCheckUser.ExecuteScalar();
                        if (userExists > 0)
                        {
                            MessageBox.Show("Username sudah terdaftar. Gunakan username lain.", "Pendaftaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // ------------------------------------


                    string query = "INSERT INTO tblPetugas (Nama_Lengkap, Username, Password, Jabatan) VALUES (@nama, @username, @password, @jabatan)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text); // Ingat hash password di produksi
                                                                                // --- UBAH INI ---
                    cmd.Parameters.AddWithValue("@jabatan", jabatanDipilih); // Ambil dari ComboBox
                                                                             // ----------------
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data petugas berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm(); // Jangan lupa notifikasi
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (btnUbah.Text == "Ubah")
            {
                if (idPetugasTerpilih == null)
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
                txtNamaLengkap.Focus();
                MessageBox.Show("Jika tidak ingin mengubah password, biarkan field password kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnUbah.Text == "Simpan" && mode == "ubah")
            {
                // --- TAMBAHKAN VALIDASI COMBOBOX ---
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    cmbJabatan.SelectedItem == null) // <-- Tambahkan ini
                {
                    MessageBox.Show("Username dan Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ------------------------------------

                string jabatanDipilih = cmbJabatan.SelectedItem.ToString();

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();

                    // --- TAMBAHKAN CEK ADMIN KEDUA (Logika Ubah) ---
                    if (jabatanDipilih == "Kepala Sarpras")
                    {
                        // Cek apakah SUDAH ADA admin lain SELAIN user yang sedang diedit ini
                        string queryCekAdmin = "SELECT COUNT(*) FROM tblPetugas WHERE Jabatan = @jabatanAdmin AND ID_Petugas != @idEdit";
                        using (SqlCommand cmdCekAdmin = new SqlCommand(queryCekAdmin, conn))
                        {
                            cmdCekAdmin.Parameters.AddWithValue("@jabatanAdmin", "Kepala Sarpras");
                            cmdCekAdmin.Parameters.AddWithValue("@idEdit", idPetugasTerpilih); // ID user yg sedang diedit
                            int otherAdminExists = (int)cmdCekAdmin.ExecuteScalar();
                            if (otherAdminExists > 0)
                            {
                                MessageBox.Show("Perubahan gagal. Hanya boleh ada satu 'Kepala Sarpras'.", "Aturan Bisnis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Hentikan proses
                            }
                        }
                    }
                    // --- CEK DUPLIKAT USERNAME (saat Ubah) ---
                    // Pastikan username baru tidak dipakai oleh user LAIN
                    string queryCheckUser = "SELECT COUNT(*) FROM tblPetugas WHERE Username = @username AND ID_Petugas != @idEdit";
                    using (SqlCommand cmdCheckUser = new SqlCommand(queryCheckUser, conn))
                    {
                        cmdCheckUser.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmdCheckUser.Parameters.AddWithValue("@idEdit", idPetugasTerpilih);
                        int userExists = (int)cmdCheckUser.ExecuteScalar();
                        if (userExists > 0)
                        {
                            MessageBox.Show("Username sudah terdaftar oleh petugas lain.", "Perubahan Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // ------------------------------------

                    string query;
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        query = "UPDATE tblPetugas SET Nama_Lengkap = @nama, Username = @username, Jabatan = @jabatan WHERE ID_Petugas = @id";
                    }
                    else
                    {
                        query = "UPDATE tblPetugas SET Nama_Lengkap = @nama, Username = @username, Password = @password, Jabatan = @jabatan WHERE ID_Petugas = @id";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    // --- UBAH INI ---
                    cmd.Parameters.AddWithValue("@jabatan", jabatanDipilih); // Ambil dari ComboBox
                                                                             // ----------------
                    cmd.Parameters.AddWithValue("@id", idPetugasTerpilih);
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text); // Ingat hash password di produksi
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data petugas berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm(); // Jangan lupa notifikasi
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengubah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPetugasTerpilih != null)
            {
                if (MessageBox.Show($"Anda yakin ingin menghapus petugas '{txtNamaLengkap.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    SqlConnection conn = kon.GetConn();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblPetugas WHERE ID_Petugas = @id", conn);
                        cmd.Parameters.AddWithValue("@id", idPetugasTerpilih);
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
            try
            {
                (dgvPetugas.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("[Nama Lengkap] LIKE '%{0}%' OR Username LIKE '%{0}%' OR Jabatan LIKE '%{0}%'", txtCari.Text);
            }
            catch (Exception) { }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvPetugas.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"Data_Petugas_{DateTime.Now:yyyyMMdd}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Menulis header kolom
                    var headers = dgvPetugas.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => $"\"{column.HeaderText}\"").ToArray()));

                    // Menulis baris data
                    foreach (DataGridViewRow row in dgvPetugas.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => $"\"{cell.Value}\"").ToArray()));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data petugas berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ofd.Title = "Pilih file CSV untuk diimpor (Petugas)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var barisGagal = new List<string>();
                int barisBerhasil = 0;

                var lines = File.ReadAllLines(ofd.FileName).Skip(1); // Lewati baris header
                Koneksi konDb = new Koneksi();
                using (SqlConnection conn = konDb.GetConn())
                {
                    await conn.OpenAsync();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (string line in lines)
                        {
                            var columns = line.Split(',');
                            if (columns.Length != 4) // Nama_Lengkap, Username, Password, Jabatan
                            {
                                barisGagal.Add($"Format salah (4 kolom diharapkan): {line}");
                                continue;
                            }

                            string namaLengkap = columns[0].Trim();
                            string username = columns[1].Trim();
                            string password = columns[2].Trim();
                            string jabatan = columns[3].Trim();

                            if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                            {
                                barisGagal.Add($"Data tidak lengkap: {line}");
                                continue;
                            }

                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblPetugas WHERE Username = @username", conn, transaction);
                            checkCmd.Parameters.AddWithValue("@username", username);
                            if ((int)await checkCmd.ExecuteScalarAsync() > 0)
                            {
                                barisGagal.Add($"Username '{username}' sudah ada: {line}");
                                continue;
                            }

                            string query = "INSERT INTO tblPetugas (Nama_Lengkap, Username, Password, Jabatan) VALUES (@nama, @username, @password, @jabatan)";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@nama", namaLengkap);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password); // PENTING: Untuk produksi, ini harus di-hash
                            cmd.Parameters.AddWithValue("@jabatan", jabatan);
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
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataPetugasChanged();
        }

        // Tambahkan metode public ini untuk menerima notifikasi
        public void RefreshGridData() { TampilkanData(); }

    }
}
