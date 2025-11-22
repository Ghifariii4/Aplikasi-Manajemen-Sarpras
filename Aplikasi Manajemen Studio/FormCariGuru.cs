using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormCariGuru : Form
    {
        // Properti publik untuk mengirim data kembali ke FormPermintaan
        public string SelectedGuruID { get; private set; }
        public string SelectedGuruNama { get; private set; }

        // Variabel untuk paginasi
        private int currentPage = 1;
        private int pageSize = 50; // Tampilkan 50 data per halaman
        private int totalRecords = 0;
        private int totalPages = 0;

        public FormCariGuru()
        {
            InitializeComponent();
            // Atur agar form ini tidak bisa di-resize dan mulai di tengah
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormCariGuru_Load(object sender, EventArgs e)
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
                string countQuery = "SELECT COUNT(*) FROM tblGuru WHERE (NIP LIKE @search OR Nama_Guru LIKE @search)";
                cmd = new SqlCommand(countQuery, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                totalRecords = (int)cmd.ExecuteScalar();
                totalPages = (totalRecords == 0) ? 1 : (int)Math.Ceiling((double)totalRecords / pageSize);

                // Ambil data untuk halaman saat ini
                int offset = (currentPage - 1) * pageSize;
                string query = @"SELECT ID_Guru, NIP, Nama_Guru, Jabatan 
                                 FROM tblGuru
                                 WHERE (NIP LIKE @search OR Nama_Guru LIKE @search)
                                 ORDER BY Nama_Guru
                                 OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvGuru.DataSource = dt;

                dgvGuru.Columns["Nama_Guru"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Update info halaman
                lblPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data guru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvGuru.CurrentRow != null)
            {
                DataGridViewRow row = dgvGuru.CurrentRow;
                this.SelectedGuruID = row.Cells["ID_Guru"].Value.ToString();
                this.SelectedGuruNama = row.Cells["Nama_Guru"].Value.ToString();

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

        private void dgvGuru_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnFirst_Click(object sender, EventArgs e) { currentPage = 1; TampilkanData(txtCari.Text); }
        private void btnPrev_Click(object sender, EventArgs e) { if (currentPage > 1) { currentPage--; TampilkanData(txtCari.Text); } }
        private void btnNext_Click(object sender, EventArgs e) { if (currentPage < totalPages) { currentPage++; TampilkanData(txtCari.Text); } }
        private void btnLast_Click(object sender, EventArgs e) { currentPage = totalPages; TampilkanData(txtCari.Text); }
    }
}