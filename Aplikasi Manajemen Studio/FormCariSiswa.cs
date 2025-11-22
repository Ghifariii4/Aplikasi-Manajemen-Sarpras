using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormCariSiswa : Form
    {
        // Properti publik untuk mengirim data kembali ke FormPermintaan
        public string SelectedSiswaID { get; private set; }
        public string SelectedSiswaNama { get; private set; }

        // Variabel untuk paginasi
        private int currentPage = 1;
        private int pageSize = 50; // Tampilkan 50 data per halaman
        private int totalRecords = 0;
        private int totalPages = 0;

        public FormCariSiswa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormCariSiswa_Load(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            TampilkanData();
        }

        private void TampilkanData(string searchTerm = "")
        {
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd;

                // Hitung total data berdasarkan pencarian
                string countQuery = "SELECT COUNT(*) FROM tblSiswa WHERE (NISN LIKE @search OR Nama_Siswa LIKE @search)";
                cmd = new SqlCommand(countQuery, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                totalRecords = (int)cmd.ExecuteScalar();
                totalPages = (totalRecords == 0) ? 1 : (int)Math.Ceiling((double)totalRecords / pageSize);

                // Ambil data untuk halaman saat ini dengan filter pencarian gabungan
                int offset = (currentPage - 1) * pageSize;
                string query = @"SELECT s.ID_Siswa, s.NISN, s.Nama_Siswa, k.Nama_Kelas 
                                 FROM tblSiswa s 
                                 JOIN tblKelas k ON s.ID_Kelas = k.ID_Kelas
                                 WHERE (s.NISN LIKE @search OR s.Nama_Siswa LIKE @search)
                                 ORDER BY s.Nama_Siswa
                                 OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvSiswa.DataSource = dt;

                dgvSiswa.Columns["Nama_Siswa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Update info halaman
                lblPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
                UpdatePaginationButtons();
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

        private void UpdatePaginationButtons()
        {
            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void PilihDanTutup()
        {
            if (dgvSiswa.CurrentRow != null)
            {
                DataGridViewRow row = dgvSiswa.CurrentRow;
                this.SelectedSiswaID = row.Cells["ID_Siswa"].Value.ToString();
                this.SelectedSiswaNama = row.Cells["Nama_Siswa"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // --- Event Handler ---
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilkanData(txtCari.Text);
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            PilihDanTutup();
        }

        private void dgvSiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PilihDanTutup();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- Event Handler Paginasi ---
        private void btnFirst_Click(object sender, EventArgs e) { currentPage = 1; TampilkanData(txtCari.Text); }
        private void btnPrev_Click(object sender, EventArgs e) { if (currentPage > 1) { currentPage--; TampilkanData(txtCari.Text); } }
        private void btnNext_Click(object sender, EventArgs e) { if (currentPage < totalPages) { currentPage++; TampilkanData(txtCari.Text); } }
        private void btnLast_Click(object sender, EventArgs e) { currentPage = totalPages; TampilkanData(txtCari.Text); }
    }
}