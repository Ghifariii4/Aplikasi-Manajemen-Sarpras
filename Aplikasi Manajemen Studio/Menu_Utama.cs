using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class Menu_Utama : Form
    {
        public Menu_Utama()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            InitializePreLoginState();

            SetupStatusBarTimer();

            btnLogout.Click += btnLogout_Click;

            btnLogin.Visible = true;
            btnLogin.Enabled = true;

            btnLogout.Visible = false;
        }

        private void InitializePreLoginState()
        {
            menu_terkunci();

            statusStripLabelStatus.Text = "Status: Belum Login";
            statusStripLabelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | HH:mm:ss WIB");

            labelNamaUser.Text = "Nama Petugas";
            labelJabatanUser.Text = "Jabatan";
            labelIDUser.Text = "ID_Petugas";

            // ShowLoginForm();
        }

        public string LoggedInNamaPetugas { get; private set; }
        public string LoggedInJabatan { get; private set; }
        public string LoggedInIDPetugas { get; private set; }

        private System.Windows.Forms.Timer _statusBarTimer;

        public void HandleLoginSuccess(string nama, string jabatan, string id)
        {
            lblNamaPetugas.Visible = true;
            lblJabatan.Visible = true;
            lblIDPetugas.Visible = true;
            titik1.Visible = true;
            titik2.Visible = true;
            titik3.Visible = true;



            LoggedInNamaPetugas = nama;
            LoggedInJabatan = jabatan;
            LoggedInIDPetugas = id;

            menu_terbuka();


            labelNamaUser.Text = $"{LoggedInNamaPetugas}";
            labelJabatanUser.Text = $"{LoggedInJabatan}";
            labelIDUser.Text = $"{LoggedInIDPetugas}";

            statusStripLabelStatus.Text = $"Status: Login sebagai {LoggedInNamaPetugas} ({LoggedInJabatan})";

            ShowDashboardForm();
        }

        void menu_terkunci()
        {
            pctUser.Visible = false;
            labelNamaUser.Visible = false;
            labelJabatanUser.Visible = false;
            labelIDUser.Visible = false;

            btnData_Barang.Enabled = false;
            btnData_Barang.BackColor = Color.Gainsboro;

            btnData_Siswa.Enabled = false;
            btnData_Siswa.BackColor = Color.Gainsboro;

            btnData_Guru.Enabled = false;
            btnData_Guru.BackColor = Color.Gainsboro;

            btnData_Kelas.Enabled = false;
            btnData_Kelas.BackColor = Color.Gainsboro;

            btnData_Petugas.Enabled = false;
            btnData_Petugas.BackColor = Color.Gainsboro;

            btn_Permintaan.Enabled = false;
            btn_Permintaan.BackColor = Color.Gainsboro;

            btn_Peminjaman.Enabled = false;
            btn_Peminjaman.BackColor = Color.Gainsboro;

            btn_Pengembalian.Enabled = false;
            btn_Pengembalian.BackColor = Color.Gainsboro;

            btn_Pembelian.Enabled = false;
            btn_Pembelian.BackColor = Color.Gainsboro;

            btnTransaksi.Enabled = false;
            btnTransaksi.BackColor = Color.Gainsboro;

            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            btnLogin.BackColor = Color.White;

            btnLogout.Visible = false;

            btnBackup.Enabled = false;
            btnBackup.BackColor = Color.Gainsboro;

            btnRestore.Enabled = false;
            btnRestore.BackColor = Color.Gainsboro;

            btnResetData.Enabled = false;
            btnResetData.BackColor = Color.Gainsboro;
        }

        void menu_terbuka()
        {
            pctUser.Visible = true;
            labelNamaUser.Visible = true;
            labelJabatanUser.Visible = true;
            labelIDUser.Visible = true;

            btnData_Barang.Enabled = true;
            btnData_Barang.BackColor = Color.White;

            btnData_Siswa.Enabled = true;
            btnData_Siswa.BackColor = Color.White;

            btnData_Guru.Enabled = true;
            btnData_Guru.BackColor = Color.White;

            btnData_Kelas.Enabled = true;
            btnData_Kelas.BackColor = Color.White;

            btnData_Petugas.Enabled = true;
            btnData_Petugas.BackColor = Color.White;

            btn_Permintaan.Enabled = true;
            btn_Permintaan.BackColor = Color.White;

            btn_Peminjaman.Enabled = true;
            btn_Peminjaman.BackColor = Color.White;

            btn_Pengembalian.Enabled = true;
            btn_Pengembalian.BackColor = Color.White;

            btn_Pembelian.Enabled = true;
            btn_Pembelian.BackColor = Color.White;

            btnTransaksi.Enabled = true;
            btnTransaksi.BackColor = Color.White;

            btnLogin.Enabled = false;
            btnLogin.Visible = false;

            btnLogout.Visible = true;

            btnBackup.Enabled = true;
            btnBackup.BackColor = Color.White;

            btnRestore.Enabled = true;
            btnRestore.BackColor = Color.White;

            btnResetData.Enabled = true;
            btnResetData.BackColor = Color.White;

            btnLaporKerusakan.Enabled = true;
            btnLaporKerusakan.BackColor = Color.White;

            if (LoggedInJabatan != "Kepala Sarpras")
            {

                btnData_Petugas.Enabled = false;
                btnData_Petugas.BackColor = Color.Gainsboro;

                btnBackup.Enabled = false;
                btnBackup.BackColor = Color.Gainsboro;

                btnRestore.Enabled = false;
                btnRestore.BackColor = Color.Gainsboro;

                btnResetData.Enabled = false;
                btnResetData.BackColor = Color.Gainsboro;
            }
        }

        private void SetupStatusBarTimer()
        {
            _statusBarTimer = new System.Windows.Forms.Timer();
            _statusBarTimer.Interval = 1000; // 1 detik
            _statusBarTimer.Tick += StatusBarTimer_Tick;
            _statusBarTimer.Start();
        }

        private void StatusBarTimer_Tick(object sender, EventArgs e)

        {
            statusStripLabelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | HH:mm:ss WIB");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form childForm in this.MdiChildren.ToList())
                {
                    childForm.Close();
                }

                InitializePreLoginState();
                // Reset state ke sebelum login
                menu_terkunci();

                LoggedInNamaPetugas = null;
                LoggedInJabatan = null;
                LoggedInIDPetugas = null;
                lblNamaPetugas.Visible = false;
                lblJabatan.Visible = false;
                lblIDPetugas.Visible = false;
                titik1.Visible = false;
                titik2.Visible = false;
                titik3.Visible = false;
            }
        }

        public void ShowMdiChildForm(Type formType)
        {
            // Cek dulu apakah form dengan tipe yang sama sudah terbuka
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formType)
                {
                    frm.BringToFront();
                    return;
                }
            }

            // --- LOGIKA HAK AKSES DIMULAI DI SINI ---
            Form newForm; // Deklarasikan variabel form

            // Cek apakah form yang akan dibuat adalah salah satu form yang butuh hak akses.
            if (formType == typeof(FormDataBarang) || formType == typeof(FormDataKelas) ||
                formType == typeof(FormDataSiswa) || formType == typeof(FormDataGuru) ||
                formType == typeof(FormDataPetugas))
            {
                // Membuat instance dengan mengirim jabatan untuk form yang butuh hak akses
                newForm = (Form)Activator.CreateInstance(formType, this.LoggedInJabatan);
            }

            else if (formType == typeof(FormPermintaan))
            {
                // FormPermintaan butuh 2 parameter: jabatan dan ID petugas
                newForm = new FormPermintaan(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormPembelian))
            {
                // FormPembelian butuh 2 parameter: jabatan dan ID petugas
                newForm = new FormPembelian(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormPeminjaman))
            {
                // FormPeminjaman butuh 2 parameter: jabatan dan ID petugas
                newForm = new FormPeminjaman(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormPengembalian))
            {
                // FormPengembalian butuh 2 parameter: jabatan dan ID petugas
                newForm = new FormPengembalian(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormLaporanAktivitas))
            {
                // FormLaporanAktivitas butuh 2 parameter: jabatan dan ID petugas
                newForm = new FormLaporanAktivitas(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormDaftarPermintaan))
            {
                // FormDaftarPermintaan butuh jabatan dan ID admin yang menyetujui
                newForm = new FormDaftarPermintaan(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormDaftarPeminjaman))
            {
                // FormDaftarPeminjaman butuh jabatan dan ID admin
                newForm = new FormDaftarPeminjaman(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else if (formType == typeof(FormLaporanKerusakan))
            {
                newForm = new FormLaporanKerusakan(this.LoggedInJabatan, this.LoggedInIDPetugas);
            }

            else
            {
                // Membuat instance biasa untuk form yang tidak butuh hak akses (seperti FormDashboard)
                newForm = (Form)Activator.CreateInstance(formType);
            }
            // --- LOGIKA HAK AKSES SELESAI ---


            // Atur properti MDI dan tampilan sesuai struktur yang Anda inginkan
            newForm.MdiParent = this;
            newForm.FormBorderStyle = FormBorderStyle.None; // Menghilangkan border
            newForm.Dock = DockStyle.Fill;                   // Mengisi seluruh panel

            newForm.Show();
        }

        private void ShowDashboardForm()
        {
            ShowMdiChildForm(typeof(FormDashboard)); // Asumsi nama form dashboard adalah FormDashboard
        }

        private void btnData_Barang_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormDataBarang));
        }

        private void btnData_Siswa_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormDataSiswa));
        }

        private void btnData_Guru_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormDataGuru));
        }

        private void btnData_Kelas_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormDataKelas));
        }

        private void btnData_Petugas_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormDataPetugas));
        }

        private void btn_Permintaan_Click(object sender, EventArgs e)
        {
            // Cek jabatan yang sedang login
            if (this.LoggedInJabatan == "Kepala Sarpras")
            {
                // Jika Admin (Kepala Sarpras), buka form daftar persetujuan
                ShowMdiChildForm(typeof(FormDaftarPermintaan));
            }
            else
            {
                // Jika bukan (misal: Staf), buka form pengajuan biasa
                ShowMdiChildForm(typeof(FormPermintaan));
            }
        }

        private void btn_Peminjaman_Click(object sender, EventArgs e)
        {
            // Cek jabatan yang sedang login
            if (this.LoggedInJabatan == "Kepala Sarpras")
            {
                // Jika Admin, buka form daftar persetujuan
                ShowMdiChildForm(typeof(FormDaftarPeminjaman));
            }
            else
            {
                // Jika bukan (misal: Staf), buka form pengajuan biasa
                ShowMdiChildForm(typeof(FormPeminjaman));
            }
        }

        private void btn_Pengembalian_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormPengembalian));
        }

        private void btn_Pembelian_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormPembelian));
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormLaporanAktivitas));
        }
        // Asumsi nama form
        //private void btnStok_Barang_Click(object sender, EventArgs e) { ShowMdiChildForm(typeof(FormLaporanStokBarang)); } // Asumsi nama form

        private void ShowLoginForm()
        {
            FormLogin loginForm = new FormLogin(this);
            loginForm.ShowDialog();

            //if (string.IsNullOrEmpty(LoggedInIDPetugas))
            //{

            //    // Application.Exit();
            //}
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void Menu_Utama_Load(object sender, EventArgs e)
        {
            // Mengatur agar panel navigasi dan top bar selalu di depan
            // dengan cara mengirim area MDI (tempat form anak muncul) ke belakang.
            Control mdiClient = this.Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                mdiClient.SendToBack();
            }

            // Panggil kondisi awal Anda di sini
            menu_terkunci();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // 1. Konfirmasi Pengguna
            if (MessageBox.Show("Anda yakin ingin melakukan backup database? Proses ini mungkin memerlukan waktu beberapa saat.",
                                "Konfirmasi Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 2. Pilih Folder Tujuan
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Pilih folder untuk menyimpan file backup database (.bak)";
                    // fbd.RootFolder = Environment.SpecialFolder.MyDocuments; // Opsional: Mulai dari folder tertentu

                    if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string folderPath = fbd.SelectedPath;
                        // Buat nama file backup dengan tanggal dan waktu
                        string fileName = $"Backup_Sarpras_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                        string backupFilePath = Path.Combine(folderPath, fileName);

                        // 3. Eksekusi Perintah BACKUP DATABASE
                        Koneksi kon = new Koneksi();
                        // Kita perlu info nama database dari connection string
                        string databaseName = "";
                        string connectionString = "";
                        try
                        {
                            using (SqlConnection tempConn = kon.GetConn())
                            {
                                databaseName = tempConn.Database; // Ambil nama database
                                connectionString = tempConn.ConnectionString; // Simpan connection string
                            }

                            if (string.IsNullOrEmpty(databaseName))
                            {
                                throw new Exception("Nama database tidak bisa didapatkan dari koneksi.");
                            }

                            // Koneksi baru untuk backup (kadang perlu hak akses berbeda atau koneksi master)
                            using (SqlConnection backupConn = new SqlConnection(connectionString)) // Gunakan koneksi yang sama
                            {
                                backupConn.Open();
                                // Perintah SQL untuk backup
                                string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH FORMAT, NAME = N'{databaseName}-Full Database Backup', STATS = 10";

                                using (SqlCommand cmd = new SqlCommand(backupQuery, backupConn))
                                {
                                    // Timeout bisa diperpanjang jika database besar
                                    cmd.CommandTimeout = 600; // Contoh: 10 menit
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // 4. Pesan Sukses
                            MessageBox.Show($"Backup database '{databaseName}' berhasil disimpan ke:\n{backupFilePath}",
                                            "Backup Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show($"Gagal melakukan backup database.\n\nSQL Error: {sqlEx.Message}\n\nPastikan folder tujuan dapat diakses dan user SQL memiliki hak akses backup.",
                                            "Backup Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Gagal melakukan backup database.\n\nError: {ex.Message}",
                                            "Backup Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            // 1. Peringatan Keras
            if (MessageBox.Show("PERINGATAN!\n\nProses restore akan MENGGANTI SEMUA DATA saat ini dengan data dari file backup.\nPastikan tidak ada pengguna lain yang sedang terhubung ke aplikasi.\n\nApakah Anda benar-benar yakin ingin melanjutkan?",
                                "Konfirmasi Restore Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // 2. Pilih File Backup (.bak)
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Backup Files (*.bak)|*.bak";
                    ofd.Title = "Pilih file backup database (.bak) untuk di-restore";

                    if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                    {
                        string backupFilePath = ofd.FileName;
                        string databaseName = "";
                        string connectionString = "";
                        Koneksi kon = new Koneksi();

                        try
                        {
                            // Ambil nama database dan connection string
                            using (SqlConnection tempConn = kon.GetConn())
                            {
                                databaseName = tempConn.Database;
                                connectionString = tempConn.ConnectionString; // Kita perlu koneksi ke master nanti
                            }

                            if (string.IsNullOrEmpty(databaseName))
                            {
                                throw new Exception("Nama database tidak bisa didapatkan dari koneksi.");
                            }

                            // 3. Proses Restore (Memerlukan koneksi ke database 'master')
                            // Bangun connection string baru ke database 'master'
                            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                            builder.InitialCatalog = "master"; // Ganti target database ke master
                            string masterConnectionString = builder.ConnectionString;

                            using (SqlConnection masterConn = new SqlConnection(masterConnectionString))
                            {
                                masterConn.Open();

                                // Set database ke Single User Mode (PENTING!)
                                string setUserModeQuery = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                                using (SqlCommand setUserModeCmd = new SqlCommand(setUserModeQuery, masterConn))
                                {
                                    setUserModeCmd.ExecuteNonQuery();
                                }

                                // Perintah SQL untuk restore
                                string restoreQuery = $"RESTORE DATABASE [{databaseName}] FROM DISK = '{backupFilePath}' WITH REPLACE";
                                using (SqlCommand cmd = new SqlCommand(restoreQuery, masterConn))
                                {
                                    cmd.CommandTimeout = 600; // Timeout 10 menit
                                    cmd.ExecuteNonQuery();
                                }

                                // Set database kembali ke Multi User Mode
                                string setMultiUserModeQuery = $"ALTER DATABASE [{databaseName}] SET MULTI_USER";
                                using (SqlCommand setMultiUserModeCmd = new SqlCommand(setMultiUserModeQuery, masterConn))
                                {
                                    setMultiUserModeCmd.ExecuteNonQuery();
                                }
                            }

                            // 4. Pesan Sukses & Saran Restart
                            MessageBox.Show($"Restore database '{databaseName}' dari file:\n{backupFilePath}\n\nBERHASIL.\n\nAplikasi perlu dimulai ulang untuk menerapkan perubahan sepenuhnya.",
                                            "Restore Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Sebaiknya langsung tutup aplikasi setelah restore
                            Application.Exit();
                        }
                        catch (SqlException sqlEx)
                        {
                            // Jika gagal, coba kembalikan ke Multi User Mode jika memungkinkan
                            try
                            {
                                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                                builder.InitialCatalog = "master";
                                using (SqlConnection recoveryConn = new SqlConnection(builder.ConnectionString))
                                {
                                    recoveryConn.Open();
                                    string setMultiUserModeQuery = $"ALTER DATABASE [{databaseName}] SET MULTI_USER";
                                    using (SqlCommand setMultiUserModeCmd = new SqlCommand(setMultiUserModeQuery, recoveryConn))
                                    {
                                        setMultiUserModeCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            catch { /* Abaikan jika recovery mode gagal */ }

                            MessageBox.Show($"Gagal melakukan restore database.\n\nSQL Error: {sqlEx.Message}\n\nPastikan file backup valid, tidak ada koneksi lain ke database, dan user SQL memiliki hak akses restore.",
                                            "Restore Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Gagal melakukan restore database.\n\nError: {ex.Message}",
                                            "Restore Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            // --- Konfirmasi Pertama (Sangat Jelas) ---
            if (MessageBox.Show("PERINGATAN SANGAT KERAS!\n\nAnda akan MENGHAPUS SEMUA DATA (Barang, Siswa, Guru, Kelas, Petugas, Permintaan, Pembelian, Peminjaman) secara PERMANEN.\n\nData yang sudah dihapus TIDAK BISA DIKEMBALIKAN kecuali Anda memiliki backup sebelumnya.\n\nApakah Anda BENAR-BENAR YAKIN ingin melanjutkan?",
                                "KONFIRMASI RESET DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // --- Konfirmasi Kedua (Mengetik Kata Kunci) ---
                // Anda bisa menggunakan InputBox (memerlukan referensi tambahan) atau form sederhana
                // Untuk contoh ini, kita gunakan MessageBox lagi, tapi dengan teks berbeda
                if (MessageBox.Show("Konfirmasi Kedua:\n\nIni adalah kesempatan terakhir Anda untuk membatalkan.\n\nKlik 'Ya' untuk melanjutkan proses PENGHAPUSAN SEMUA DATA.",
                                    "KONFIRMASI AKHIR RESET DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    using (SqlConnection conn = kon.GetConn())
                    {
                        SqlTransaction transaction = null;
                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction();

                            // Perintah DELETE harus dalam urutan yang benar untuk menghindari error Foreign Key
                            // Hapus data transaksi terlebih dahulu
                            new SqlCommand("DELETE FROM tblPermintaan_Detail", conn, transaction).ExecuteNonQuery();
                            new SqlCommand("DELETE FROM tblPermintaan_Header", conn, transaction).ExecuteNonQuery();
                            new SqlCommand("DELETE FROM tblPeminjaman", conn, transaction).ExecuteNonQuery();
                            new SqlCommand("DELETE FROM tblPembelian", conn, transaction).ExecuteNonQuery();

                            // Hapus data master (perhatikan relasi, hapus Siswa sebelum Kelas jika diperlukan)
                            // Anda mungkin ingin mengecualikan user admin saat ini dari penghapusan tblPetugas
                            new SqlCommand("DELETE FROM tblSiswa", conn, transaction).ExecuteNonQuery();
                            new SqlCommand("DELETE FROM tblGuru", conn, transaction).ExecuteNonQuery();
                            new SqlCommand($"DELETE FROM tblPetugas WHERE ID_Petugas != {this.LoggedInIDPetugas}", conn, transaction).ExecuteNonQuery(); // Hapus semua KECUALI user saat ini
                            new SqlCommand("DELETE FROM tblKelas", conn, transaction).ExecuteNonQuery();
                            new SqlCommand("DELETE FROM tblBarang", conn, transaction).ExecuteNonQuery();

                            // (Opsional) Reset ID Auto Increment jika diperlukan (lebih advance)
                            // DBCC CHECKIDENT ('tblBarang', RESEED, 0);
                            // DBCC CHECKIDENT ('tblKelas', RESEED, 0);
                            // ... dan seterusnya

                            transaction.Commit(); // Lakukan commit jika semua delete berhasil
                            MessageBox.Show("Semua data berhasil direset.", "Reset Data Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // --- Refresh Tampilan ---
                            // Tutup semua form anak yang mungkin menampilkan data lama
                            foreach (Form childForm in this.MdiChildren.ToList())
                            {
                                // Jangan tutup dashboard, cukup refresh jika bisa
                                if (!(childForm is FormDashboard))
                                {
                                    childForm.Close();
                                }
                            }
                            // Buka kembali dashboard untuk refresh
                            ShowDashboardForm();

                        }
                        catch (Exception ex)
                        {
                            if (transaction != null) transaction.Rollback(); // Batalkan semua jika ada error
                            MessageBox.Show($"Gagal mereset data: {ex.Message}", "Reset Data Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // --- Metode Notifikasi Perubahan Data ---
        // (Tambahkan ini di dalam class Menu_Utama)

        public void NotifyDataBarangChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique names
                if (childForm is FormPembelian formPembelian) formPembelian.ReloadBarangComboBox();
                else if (childForm is FormPermintaan formPermintaan) formPermintaan.ReloadBarangComboBox();
                else if (childForm is FormPeminjaman formPeminjaman) formPeminjaman.ReloadBarangComboBox();
                else if (childForm is FormDashboard formDashboard) formDashboard.RefreshDashboardData();
                else if (childForm is FormLaporanKerusakan formKerusakan)
                {
                    formKerusakan.ReloadBarangComboBox();
                }
                else if (childForm is FormDataBarang formDataBarang) formDataBarang.RefreshGridData();

            }
        }

        public void NotifyDataGuruChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique name
                if (childForm is FormDataGuru formDataGuru) formDataGuru.RefreshGridData();
                // Add else if for other forms if needed
            }
        }

        public void NotifyDataSiswaChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique name
                if (childForm is FormDataSiswa formDataSiswa) formDataSiswa.RefreshGridData();
                // Add else if for other forms if needed
            }
        }

        public void NotifyDataKelasChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique names
                if (childForm is FormDataKelas formDataKelas) formDataKelas.RefreshGridData();
                else if (childForm is FormDataSiswa formDataSiswa) formDataSiswa.ReloadKelasComboBox();
            }
        }

        public void NotifyDataPetugasChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique names
                if (childForm is FormDataPetugas formDataPetugas) formDataPetugas.RefreshGridData();
                else if (childForm is FormLaporanAktivitas formLaporan) formLaporan.RefreshAllTabsData();
            }
        }

        public void NotifyPembelianChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique names
                if (childForm is FormDataBarang formDataBarang) formDataBarang.RefreshGridData();
                else if (childForm is FormDashboard formDashboard) formDashboard.RefreshDashboardData();
                else if (childForm is FormPermintaan formPermintaan) formPermintaan.ReloadBarangComboBox();
                else if (childForm is FormPeminjaman formPeminjaman) formPeminjaman.ReloadBarangComboBox();
                else if (childForm is FormPembelian formPembelian) formPembelian.RefreshRiwayatPembelian();
                else if (childForm is FormLaporanAktivitas formLaporan) formLaporan.RefreshPembelianTab();
            }
        }

        public void NotifyPermintaanChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Gunakan nama variabel yang berbeda untuk setiap tipe form
                if (childForm is FormDataBarang formDataBarang) formDataBarang.RefreshGridData();
                else if (childForm is FormDashboard formDashboard) formDashboard.RefreshDashboardData();
                else if (childForm is FormPermintaan formPermintaan) formPermintaan.ReloadBarangComboBox();
                else if (childForm is FormPeminjaman formPeminjaman) formPeminjaman.ReloadBarangComboBox();
                else if (childForm is FormPembelian formPembelian) formPembelian.ReloadBarangComboBox();
                else if (childForm is FormLaporanAktivitas formLaporan) formLaporan.RefreshPermintaanTab();
            }
        }

        public void NotifyPeminjamanChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique variable names
                if (childForm is FormDataBarang formDataBarang) formDataBarang.RefreshGridData();
                else if (childForm is FormDashboard formDashboard) formDashboard.RefreshDashboardData();
                else if (childForm is FormPermintaan formPermintaan) formPermintaan.ReloadBarangComboBox();
                else if (childForm is FormPeminjaman formPeminjaman) formPeminjaman.ReloadBarangComboBox();
                else if (childForm is FormPembelian formPembelian) formPembelian.ReloadBarangComboBox();
                else if (childForm is FormPengembalian formPengembalian) formPengembalian.RefreshPeminjamData();
                else if (childForm is FormLaporanAktivitas formLaporan) formLaporan.RefreshPeminjamanTab();
            }
        }

        public void NotifyPengembalianChanged()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Use unique variable names
                if (childForm is FormDataBarang formDataBarang) formDataBarang.RefreshGridData();
                else if (childForm is FormDashboard formDashboard) formDashboard.RefreshDashboardData();
                else if (childForm is FormPermintaan formPermintaan) formPermintaan.ReloadBarangComboBox();
                else if (childForm is FormPeminjaman formPeminjaman) formPeminjaman.ReloadBarangComboBox();
                else if (childForm is FormPembelian formPembelian) formPembelian.ReloadBarangComboBox();
                else if (childForm is FormPengembalian formPengembalian) formPengembalian.RefreshPeminjamData();
                else if (childForm is FormLaporanAktivitas formLaporan) formLaporan.RefreshPeminjamanTab();
            }
        }

        private void btnLaporKerusakan_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(typeof(FormLaporanKerusakan));
        }
    }
}
