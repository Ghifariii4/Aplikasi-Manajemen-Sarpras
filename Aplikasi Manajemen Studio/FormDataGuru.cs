using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq; 
using System.Collections.Generic;

namespace Aplikasi_Manajemen_Studio // Sesuaikan dengan namespace Anda
{
    public partial class FormDataGuru : Form
    {
        private string mode;
        private string idGuruTerpilih;
        private string userJabatan;

        public FormDataGuru(string jabatan)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.userJabatan = jabatan;

            cmbJabatan.DataSource = daftarJabatanGuru;
            cmbJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
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
            txtNip.Text = "";
            txtNamaGuru.Text = "";
            cmbJabatan.Text = "";
            idGuruTerpilih = null;
            cmbJabatan.SelectedIndex = -1;
        }

        private void InputFields(bool isEnabled)
        {
            txtNip.Enabled = isEnabled;
            txtNamaGuru.Enabled = isEnabled;
            cmbJabatan.Enabled = isEnabled;
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
                SqlCommand cmd = new SqlCommand("SELECT ID_Guru, NIP, Nama_Guru, Jabatan FROM tblGuru", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvGuru.DataSource = dt;

                dgvGuru.Columns["ID_Guru"].HeaderText = "ID";
                dgvGuru.Columns["NIP"].HeaderText = "NIP";
                dgvGuru.Columns["Nama_Guru"].HeaderText = "Nama Guru";
                dgvGuru.Columns["Jabatan"].HeaderText = "Jabatan";
                dgvGuru.Columns["Nama_Guru"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        // --- Event Handler ---

        private List<string> daftarJabatanGuru = new List<string>()
        {
            "KEPALA SEKOLAH",
            "WAKIL KEPALA SEKOLAH BIDANG KURIKULUM",
            "WAKIL KEPALA SEKOLAH BIDANG KESISWAAN",
            "STAF KURIKULUM",
            "STAF TATA USAHA",
            "KEPALA PROGRAM",
            "GURU AKUNTANSI",
            "GURU PEMASARAN",
            "GURU OTKP",
            "GURU USAHA LAYANAN PARIWISATA",
            "GURU REKAYASA PERANGKAT LUNAK",
            "KOORDINATOR GURU",
            // Jabatan Guru Umum & Spesifik
    "GURU",
    "GURU AKUNTANSI",
    "GURU BAHASA INDONESIA",
    "GURU BAHASA INGGRIS",
    "GURU BIMBINGAN DAN KONSELING/KONSELOR (BP/BK)",
    "GURU BIMBINGAN DAN KONSELING/KONSELOR (SP/BK)",
    "GURU BISNIS DIGITAL",
    "GURU BISNIS RETAIL",
    "GURU DASAR DASAR AKUNTANSI DAN KEUANGAN LEMBAGA",
    "GURU DASAR DASAR MANAJEMEN PERKANTORAN DAN LAYANAN BISNIS",
    "GURU DASAR DASAR PEMASARAN",
    "GURU DASAR DASAR PENGEMBANGAN PERANGKAT LUNAK DAN GIM",
    "GURU DASAR DASAR USAHA LAYANAN PARIWISATA",
    "GURU INFORMATIKA",
    "GURU KREATIVITAS, INOVASI, DAN KEWIRAUSAHAAN",
    "GURU MANAJEMEN PERKANTORAN",
    "GURU MATEMATIKA (UMUM)",
    "GURU PENDIDIKAN AGAMA ISLAM DAN BUDI PEKERTI",
    "GURU PENDIDIKAN AGAMA KRISTEN DAN BUDI PEKERTI",
    "GURU PENDIDIKAN JASMANI, OLAHRAGA, DAN KESEHATAN",
    "GURU PENDIDIKAN PANCASILA",
    "GURU PENDIDIKAN KEPERCAYAAN TERHADAP TUHAN YME DAN BUDI PEKERTI",
    "GURU PROJEK IPAS",
    "GURU USAHA LAYANAN WISATA"

        };


        private void FormDataGuru_Load(object sender, EventArgs e)
        {
            TampilkanData();
            KondisiAwal();

            if (userJabatan != "Kepala Sarpras")
            {
                btnTambah.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnBatal.Visible = false;
                btnImpor.Visible = false;
                btnEkspor.Visible = false;
            }


        }

        private void dgvGuru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mode == "")
            {
                DataGridViewRow row = dgvGuru.Rows[e.RowIndex];
                idGuruTerpilih = row.Cells["ID_Guru"].Value.ToString();
                txtNip.Text = row.Cells["NIP"].Value.ToString();
                txtNamaGuru.Text = row.Cells["Nama_Guru"].Value.ToString();

                // Ubah ini: Set nilai ComboBox
                string jabatanDariGrid = row.Cells["Jabatan"].Value.ToString();
                if (daftarJabatanGuru.Contains(jabatanDariGrid))
                {
                    cmbJabatan.SelectedItem = jabatanDariGrid;
                }
                else
                {
                    cmbJabatan.SelectedIndex = -1;
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
                txtNip.Focus();
            }
            else if (btnTambah.Text == "Simpan" && mode == "tambah")
            {
                if (string.IsNullOrWhiteSpace(txtNip.Text) || string.IsNullOrWhiteSpace(txtNamaGuru.Text) || cmbJabatan.SelectedItem == null)
                {
                    MessageBox.Show("NIP, Nama Guru, dan Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tblGuru (NIP, Nama_Guru, Jabatan) VALUES (@nip, @nama, @jabatan)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", txtNip.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNamaGuru.Text);
                    cmd.Parameters.AddWithValue("@jabatan", cmbJabatan.SelectedItem.ToString()); // Ubah ini
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data guru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (idGuruTerpilih == null)
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
                txtNip.Focus();
            }
            else if (btnUbah.Text == "Simpan" && mode == "ubah")
            {
                if (string.IsNullOrWhiteSpace(txtNip.Text) || string.IsNullOrWhiteSpace(txtNamaGuru.Text) || cmbJabatan.SelectedItem == null)
                {
                    MessageBox.Show("NIP, Nama Guru, dan Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Koneksi kon = new Koneksi();
                SqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "UPDATE tblGuru SET NIP = @nip, Nama_Guru = @nama, Jabatan = @jabatan WHERE ID_Guru = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", txtNip.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNamaGuru.Text);
                    cmd.Parameters.AddWithValue("@jabatan", cmbJabatan.SelectedItem.ToString()); // Ubah ini
                    cmd.Parameters.AddWithValue("@id", idGuruTerpilih);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data guru berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (idGuruTerpilih != null)
            {
                if (MessageBox.Show($"Anda yakin ingin menghapus data guru '{txtNamaGuru.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    SqlConnection conn = kon.GetConn();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblGuru WHERE ID_Guru = @id", conn);
                        cmd.Parameters.AddWithValue("@id", idGuruTerpilih);
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
                (dgvGuru.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("NIP LIKE '%{0}%' OR [Nama Guru] LIKE '%{0}%' OR Jabatan LIKE '%{0}%'", txtCari.Text);
            }
            catch (Exception) { }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Di dalam class FormDataGuru
        private async void btnImpor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File (*.csv)|*.csv";
            ofd.Title = "Pilih file CSV untuk diimpor (Guru)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var barisGagal = new List<string>();
                int barisBerhasil = 0;

                var lines = File.ReadAllLines(ofd.FileName).Skip(1);
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
                            if (columns.Length != 3)
                            {
                                barisGagal.Add($"Format salah (3 kolom diharapkan): {line}");
                                continue;
                            }

                            // --- PERBAIKAN DI SINI: Hapus spasi DAN tanda kutip ---
                            string nip = columns[0].Trim().Trim('"');
                            string namaGuru = columns[1].Trim().Trim('"');
                            string jabatan = columns[2].Trim().Trim('"');
                            // ----------------------------------------------------

                            if (string.IsNullOrEmpty(nip) || string.IsNullOrEmpty(namaGuru) || string.IsNullOrEmpty(jabatan))
                            {
                                barisGagal.Add($"Data tidak lengkap: {line}");
                                continue;
                            }

                            if (!daftarJabatanGuru.Contains(jabatan.ToUpper()))
                            {
                                barisGagal.Add($"Jabatan '{jabatan}' tidak valid: {line}");
                                continue;
                            }

                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblGuru WHERE NIP = @nip", conn, transaction);
                            checkCmd.Parameters.AddWithValue("@nip", nip);
                            if ((int)await checkCmd.ExecuteScalarAsync() > 0)
                            {
                                barisGagal.Add($"NIP '{nip}' sudah ada: {line}");
                                continue;
                            }

                            string query = "INSERT INTO tblGuru (NIP, Nama_Guru, Jabatan) VALUES (@nip, @nama, @jabatan)";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@nip", nip);
                            cmd.Parameters.AddWithValue("@nama", namaGuru);
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

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvGuru.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"Data_Guru_{DateTime.Now:yyyyMMdd}.csv";
            sfd.Title = "Ekspor Data Guru";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // --- PERBAIKAN DI SINI ---
                    // Tulis header secara manual agar sesuai format impor (3 kolom)
                    sb.AppendLine("\"NIP\",\"Nama_Guru\",\"Jabatan\"");

                    // Menulis baris data
                    foreach (DataGridViewRow row in dgvGuru.Rows)
                    {
                        // Pastikan sel tidak null sebelum mengambil nilainya
                        string nip = row.Cells["NIP"].FormattedValue?.ToString() ?? "";
                        string nama = row.Cells["Nama_Guru"].FormattedValue?.ToString() ?? "";
                        string jabatan = row.Cells["Jabatan"].FormattedValue?.ToString() ?? "";

                        // Bungkus dengan tanda kutip
                        sb.AppendLine($"\"{nip}\",\"{nama}\",\"{jabatan}\"");
                    }
                    // -------------------------

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data guru berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor data guru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyDataGuruChanged();
        }

        public void RefreshGridData() { TampilkanData(); }
    }
}