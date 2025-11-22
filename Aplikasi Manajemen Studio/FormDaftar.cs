using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            // --- DIUBAH ---
            // Mengisi ComboBox Jabatan sesuai permintaan Anda
            cmbJabatan.Items.Add("Kepala Sarpras"); // Ini akan dianggap sebagai Admin
            cmbJabatan.Items.Add("Staff");
            cmbJabatan.SelectedIndex = 1; // Default-nya adalah "Staff"
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtKonfirmasiPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtKonfirmasiPassword.PasswordChar = '*';
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input (txtIDPetugas dihapus)
            if (string.IsNullOrWhiteSpace(txtNamaLengkap.Text))
            {
                MessageBox.Show("Nama Lengkap tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLengkap.Focus();
                return;
            }
            if (cmbJabatan.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih Jabatan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbJabatan.Focus();
                return;
            }
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
            if (txtPassword.Text != txtKonfirmasiPassword.Text)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKonfirmasiPassword.Focus();
                return;
            }

            string jabatanDipilih = cmbJabatan.SelectedItem.ToString();

            // 2. Proses Pendaftaran ke Database
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();

            try
            {
                conn.Open();

                // Langkah A: Cek jika mendaftar sebagai "Kepala Sarpras" dan sudah ada
                if (jabatanDipilih == "Kepala Sarpras")
                {
                    string queryCekAdmin = "SELECT COUNT(*) FROM tblPetugas WHERE Jabatan = @jabatanAdmin";
                    using (SqlCommand cmdCekAdmin = new SqlCommand(queryCekAdmin, conn))
                    {
                        cmdCekAdmin.Parameters.AddWithValue("@jabatanAdmin", "Kepala Sarpras");
                        int adminExists = (int)cmdCekAdmin.ExecuteScalar();

                        if (adminExists > 0)
                        {
                            MessageBox.Show("Pendaftaran gagal. Hanya boleh ada satu 'Kepala Sarpras' (Admin) dalam sistem.", "Aturan Bisnis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Langkah B: Periksa apakah Username sudah ada (Pengecekan ID dihapus)
                // --- QUERY DIUBAH ---
                string queryCheck = "SELECT COUNT(*) FROM tblPetugas WHERE Username = @username";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                {
                    // Parameter @id dihapus
                    cmdCheck.Parameters.AddWithValue("@username", txtUsername.Text);

                    int userExists = (int)cmdCheck.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username sudah terdaftar. Silakan gunakan yang lain.", "Pendaftaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Langkah C: Lakukan INSERT (Kolom ID_Petugas dihapus dari query)
                // --- QUERY DIUBAH ---
                string queryInsert = "INSERT INTO tblPetugas (Nama_Lengkap, Jabatan, Username, Password) " +
                                     "VALUES (@nama, @jabatan, @username, @password)";

                using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                {
                    // Parameter @id dihapus
                    cmdInsert.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                    cmdInsert.Parameters.AddWithValue("@jabatan", jabatanDipilih);
                    cmdInsert.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmdInsert.Parameters.AddWithValue("@password", txtPassword.Text);

                    int rowsAffected = cmdInsert.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registrasi petugas baru berhasil!", "Pendaftaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan, registrasi gagal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}