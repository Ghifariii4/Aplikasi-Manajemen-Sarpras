using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio // Sesuaikan dengan namespace Anda
{
    public partial class FormDataKelas : Form
    {
        private string mode;
        private string idKelasTerpilih;
        private string userJabatan;

        public FormDataKelas(string jabatan)
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
            txtNamaKelas.Text = "";
            txtTingkat.Text = "";
            idKelasTerpilih = null;
        }

        private void InputFields(bool isEnabled)
        {
            txtNamaKelas.Enabled = isEnabled;
            txtTingkat.Enabled = isEnabled;
        }

        // --- Metode untuk Menampilkan Data ---

        private void TampilkanData()
        {
            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Kelas, Nama_Kelas, Tingkat FROM tblKelas", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvKelas.DataSource = dt;

                dgvKelas.Columns["ID_Kelas"].HeaderText = "ID";
                dgvKelas.Columns["Nama_Kelas"].HeaderText = "Nama Kelas";
                dgvKelas.Columns["Tingkat"].HeaderText = "Tingkat";
                dgvKelas.Columns["Nama_Kelas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data kelas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // --- Event Handler ---

        private void FormDataKelas_Load(object sender, EventArgs e)
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

        private void dgvKelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mode == "")
            {
                DataGridViewRow row = dgvKelas.Rows[e.RowIndex];
                idKelasTerpilih = row.Cells["ID_Kelas"].Value.ToString();
                txtNamaKelas.Text = row.Cells["Nama_Kelas"].Value.ToString();
                txtTingkat.Text = row.Cells["Tingkat"].Value.ToString();

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
                txtNamaKelas.Focus();
            }
            else if (btnTambah.Text == "Simpan" && mode == "tambah")
            {
                if (string.IsNullOrWhiteSpace(txtNamaKelas.Text) || string.IsNullOrWhiteSpace(txtTingkat.Text))
                {
                    MessageBox.Show("Nama Kelas dan TIngkat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tblKelas (Nama_Kelas, Tingkat) VALUES (@nama, @tingkat)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNamaKelas.Text);
                    cmd.Parameters.AddWithValue("@tingkat", txtTingkat.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data kelas berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
                TampilkanData();
                KondisiAwal();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (btnUbah.Text == "Ubah")
            {
                if (idKelasTerpilih == null)
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
                txtNamaKelas.Focus();
            }
            else if (btnUbah.Text == "Simpan" && mode == "ubah")
            {
                if (string.IsNullOrWhiteSpace(txtNamaKelas.Text) || string.IsNullOrWhiteSpace(txtTingkat.Text))
                {
                    MessageBox.Show("Nama Kelas dan Tingkat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "UPDATE tblKelas SET Nama_Kelas = @nama, Tingkat = @tingkat WHERE ID_Kelas = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNamaKelas.Text);
                    cmd.Parameters.AddWithValue("@tingkat", txtTingkat.Text);
                    cmd.Parameters.AddWithValue("@id", idKelasTerpilih);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data kelas berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
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
            if (idKelasTerpilih != null)
            {
                if (MessageBox.Show($"Anda yakin ingin menghapus kelas '{txtNamaKelas.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    SqlConnection conn = kon.GetConn();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblKelas WHERE ID_Kelas = @id", conn);
                        cmd.Parameters.AddWithValue("@id", idKelasTerpilih);
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
                (dgvKelas.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Nama_Kelas LIKE '%{0}%' OR Tingkat LIKE '%{0}%'", txtCari.Text);
            }
            catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvKelas.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"Data_Kelas_{DateTime.Now:yyyyMMdd}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Menulis header kolom (tanpa kolom ID)
                    var headers = dgvKelas.Columns.Cast<DataGridViewColumn>()
                                        .Where(column => column.HeaderText != "ID");
                    sb.AppendLine(string.Join(",", headers.Select(column => $"\"{column.HeaderText}\"").ToArray()));

                    // Menulis baris data
                    foreach (DataGridViewRow row in dgvKelas.Rows)
                    {
                        // Mengambil nilai hanya dari kolom yang terlihat
                        string namaKelas = $"\"{row.Cells["Nama_Kelas"].Value}\"";
                        string tingkat = $"\"{row.Cells["Tingkat"].Value}\"";
                        sb.AppendLine(string.Join(",", namaKelas, tingkat));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data kelas berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ofd.Title = "Pilih file CSV untuk diimpor (Kelas)";

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
                            if (columns.Length != 2) // Nama_Kelas, Tingkat
                            {
                                barisGagal.Add($"Format salah (2 kolom diharapkan): {line}");
                                continue;
                            }

                            string namaKelas = columns[0].Trim();
                            string tingkat = columns[1].Trim();

                            if (string.IsNullOrEmpty(namaKelas) || string.IsNullOrEmpty(tingkat))
                            {
                                barisGagal.Add($"Data tidak lengkap: {line}");
                                continue;
                            }

                            // Cek duplikasi Nama Kelas
                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblKelas WHERE Nama_Kelas = @namaKelas", conn, transaction);
                            checkCmd.Parameters.AddWithValue("@namaKelas", namaKelas);
                            if ((int)await checkCmd.ExecuteScalarAsync() > 0)
                            {
                                barisGagal.Add($"Nama Kelas '{namaKelas}' sudah ada: {line}");
                                continue;
                            }

                            string query = "INSERT INTO tblKelas (Nama_Kelas, Tingkat) VALUES (@nama, @tingkat)";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@nama", namaKelas);
                            cmd.Parameters.AddWithValue("@tingkat", tingkat);
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
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataKelasChanged();
        }

        // Tambahkan metode public ini untuk menerima notifikasi
        public void RefreshGridData() { TampilkanData(); }

    }
}