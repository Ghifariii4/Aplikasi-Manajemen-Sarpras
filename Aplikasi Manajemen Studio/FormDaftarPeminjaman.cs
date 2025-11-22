using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio
{
    // Pastikan nama class ini sesuai dengan nama file/form Anda
    public partial class FormDaftarPeminjaman : Form
    {
        private string userJabatan;
        private string idPetugasPenyetuju;
        private string idPeminjamanTerpilih; // Simpan ID Header

        public FormDaftarPeminjaman(string jabatan, string idPetugas)
        {
            InitializeComponent();
            this.userJabatan = jabatan;
            this.idPetugasPenyetuju = idPetugas;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormDaftarPeminjaman_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            TampilkanDataPending();
        }

        private void KondisiAwal()
        {
            dgvDetailPending.DataSource = null;
            idPeminjamanTerpilih = null;
            btnSetuju.Enabled = false;
            btnTolak.Enabled = false;
        }

        private void TampilkanDataPending()
        {
            KondisiAwal();
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            H.ID_Peminjaman, 
                            H.Tgl_Pinjam,
                            H.Tgl_JatuhTempo,
                            ISNULL(G.Nama_Guru, S.Nama_Siswa) AS Peminjam, 
                            H.Status
                        FROM tblPeminjaman_Header H
                        LEFT JOIN tblGuru G ON H.ID_Guru_Peminjam = G.ID_Guru
                        LEFT JOIN tblSiswa S ON H.ID_Siswa_Peminjam = S.ID_Siswa
                        WHERE H.Status = 'Pending'
                        ORDER BY H.Tgl_Pinjam ASC";

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvPending.DataSource = dt; // Pastikan nama DGV Anda benar

                    // Styling Kolom
                    dgvPending.Columns["ID_Peminjaman"].HeaderText = "ID";
                    dgvPending.Columns["Tgl_Pinjam"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvPending.Columns["Tgl_JatuhTempo"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvPending.Columns["Peminjam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TampilkanDetail(string idPeminjaman)
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            D.ID_Barang, 
                            B.Nama_Barang, 
                            D.Jumlah, 
                            B.Stok AS Stok_Saat_Ini
                        FROM tblPeminjaman_Detail D
                        JOIN tblBarang B ON D.ID_Barang = B.ID_Barang
                        WHERE D.ID_Peminjaman = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idPeminjaman);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvDetailPending.DataSource = dt; // Pastikan nama DGV Detail Anda benar

                    dgvDetailPending.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat detail peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPeminjamanTerpilih = dgvPending.Rows[e.RowIndex].Cells["ID_Peminjaman"].Value.ToString();
                TampilkanDetail(idPeminjamanTerpilih);
                btnSetuju.Enabled = true;
                btnTolak.Enabled = true;
            }
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            if (idPeminjamanTerpilih == null) return;
            if (MessageBox.Show("Anda yakin ingin menyetujui peminjaman ini? Stok barang akan dikurangi.", "Konfirmasi Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Validasi dan update stok
                    foreach (DataGridViewRow row in dgvDetailPending.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip baris baru

                        int idBarang = Convert.ToInt32(row.Cells["ID_Barang"].Value);
                        int jumlahDiminta = Convert.ToInt32(row.Cells["Jumlah"].Value);
                        string namaBarang = row.Cells["Nama_Barang"].Value.ToString();

                        string queryUpdateStok = "UPDATE tblBarang SET Stok = Stok - @jml WHERE ID_Barang = @id AND Stok >= @jml";
                        SqlCommand cmdUpdateStok = new SqlCommand(queryUpdateStok, conn, transaction);
                        cmdUpdateStok.Parameters.AddWithValue("@jml", jumlahDiminta);
                        cmdUpdateStok.Parameters.AddWithValue("@id", idBarang);

                        int rowsAffected = cmdUpdateStok.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception($"Stok untuk '{namaBarang}' tidak mencukupi!");
                        }
                    }

                    // 2. Jika semua stok berhasil, update header
                    string queryUpdateHeader = "UPDATE tblPeminjaman_Header SET Status = 'Dipinjam', ID_Petugas_Penyetuju = @idPetugas, Tgl_Disetujui = @tgl WHERE ID_Peminjaman = @id";
                    SqlCommand cmdUpdateHeader = new SqlCommand(queryUpdateHeader, conn, transaction);
                    cmdUpdateHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPenyetuju);
                    cmdUpdateHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmdUpdateHeader.Parameters.AddWithValue("@id", idPeminjamanTerpilih);
                    cmdUpdateHeader.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Peminjaman berhasil disetujui. Stok barang telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyetujui peminjaman:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TampilkanDataPending();
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (idPeminjamanTerpilih == null) return;
            if (MessageBox.Show("Anda yakin ingin menolak peminjaman ini?", "Konfirmasi Penolakan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string queryUpdateHeader = "UPDATE tblPeminjaman_Header SET Status = 'Ditolak', ID_Petugas_Penyetuju = @idPetugas, Tgl_Disetujui = @tgl WHERE ID_Peminjaman = @id";
                    SqlCommand cmdUpdateHeader = new SqlCommand(queryUpdateHeader, conn);
                    cmdUpdateHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPenyetuju);
                    cmdUpdateHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmdUpdateHeader.Parameters.AddWithValue("@id", idPeminjamanTerpilih);
                    cmdUpdateHeader.ExecuteNonQuery();

                    MessageBox.Show("Peminjaman berhasil ditolak.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menolak peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TampilkanDataPending();
        }

        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent)
            {
                parent.NotifyPeminjamanChanged();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanDataPending();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}