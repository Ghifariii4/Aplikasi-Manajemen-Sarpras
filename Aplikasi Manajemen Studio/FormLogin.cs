using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Penting untuk koneksi ke SQL Server

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormLogin : Form
    {
        private readonly Menu_Utama _mainForm;

        public FormLogin(Menu_Utama mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 2. Proses Verifikasi ke Database
            Koneksi kon = new Koneksi(); // Buat instance dari class Koneksi Anda
            SqlConnection conn = kon.GetConn(); // Dapatkan objek koneksi

            try
            {
                conn.Open();

                // Query untuk memverifikasi Username dan Password
                string query = "SELECT ID_Petugas, Nama_Lengkap, Jabatan FROM tblPetugas WHERE Username = @username AND Password = @password";

                // CATATAN PENTING TENTANG PASSWORD:
                // Sekali lagi ditekankan, untuk aplikasi nyata, simpan password sebagai HASH (misal: SHA256).
                // Di sini kita masih menggunakan teks biasa untuk kesederhanaan proyek.

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text); // Menggunakan txtUsername untuk kolom Username
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows) // Jika data ditemukan
                        {
                            reader.Read(); // Baca baris data

                            // Ambil data petugas dari hasil query
                            string idPetugas = reader["ID_Petugas"].ToString();
                            string namaLengkap = reader["Nama_Lengkap"].ToString();
                            string jabatan = reader["Jabatan"].ToString();

                            // Panggil metode di Form Utama untuk memberitahu bahwa login berhasil
                            _mainForm.HandleLoginSuccess(namaLengkap, jabatan, idPetugas);

                            MessageBox.Show("Login berhasil! Selamat datang, " + namaLengkap, "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tutup form login
                            this.Close();
                        }
                        else // Jika tidak ada data yang cocok
                        {
                            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghubungkan atau memverifikasi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Pastikan koneksi ditutup
                }
            }
        }

        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Buat instance baru dari FormDaftar
            FormDaftar formDaftar = new FormDaftar();

            // 2. Tampilkan form daftar sebagai dialog modal
            //    Ini akan menghentikan sementara FormLogin sampai FormDaftar ditutup.
            formDaftar.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}