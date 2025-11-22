using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic; // Untuk List<int>

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormPengembalian : Form
    {
        private string idPeminjamTerpilih = null;
        private string tipePeminjam = "Guru";
        private string idPetugasPencatat;

        // --- BARU: Menyimpan ID Header untuk cek status ---
        private Dictionary<int, int> detailKeHeaderMap = new Dictionary<int, int>();

        public FormPengembalian(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasPencatat = idPetugasLogin;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            KondisiAwal();
        }

        private void SetupDataGridView()
        {
            // (Kode SetupDataGridView Anda sudah bagus, tidak perlu diubah)
            if (dgvBarangDipinjam.Columns["colPilih"] == null)
            {
                DataGridViewCheckBoxColumn colPilih = new DataGridViewCheckBoxColumn();
                colPilih.Name = "colPilih";
                colPilih.HeaderText = "Pilih";
                colPilih.Width = 50;
                dgvBarangDipinjam.Columns.Insert(0, colPilih);
            }
        }

        private void KondisiAwal()
        {
            rbGuru.Checked = true;
            idPeminjamTerpilih = null;
            txtNamaPeminjam.Text = "";
            dgvBarangDipinjam.DataSource = null;
            btnProsesPengembalian.Enabled = false;
        }

        // --- Event Handler Pilihan Peminjam ---

        private void rbGuru_Siswa_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedRb = sender as RadioButton;
            if (clickedRb != null && clickedRb.Checked)
            {
                if (clickedRb == rbGuru) tipePeminjam = "Guru";
                else if (clickedRb == rbSiswa) tipePeminjam = "Siswa";

                // Reset saat ganti tipe
                idPeminjamTerpilih = null;
                txtNamaPeminjam.Text = "";
                dgvBarangDipinjam.DataSource = null;
                btnProsesPengembalian.Enabled = false;
            }
        }

        private void btnCariPeminjam_Click(object sender, EventArgs e)
        {
            if (tipePeminjam == "Guru")
            {
                using (FormCariGuru frm = new FormCariGuru())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        idPeminjamTerpilih = frm.SelectedGuruID;
                        txtNamaPeminjam.Text = frm.SelectedGuruNama;
                        TampilkanBarangDipinjam();
                    }
                }
            }
            else // Siswa
            {
                using (FormCariSiswa frm = new FormCariSiswa())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        idPeminjamTerpilih = frm.SelectedSiswaID;
                        txtNamaPeminjam.Text = frm.SelectedSiswaNama;
                        TampilkanBarangDipinjam();
                    }
                }
            }
        }

        // --- PEROMBAKAN BESAR DI SINI ---
        private void TampilkanBarangDipinjam()
        {
            if (idPeminjamTerpilih == null)
            {
                dgvBarangDipinjam.DataSource = null;
                btnProsesPengembalian.Enabled = false;
                return;
            }

            // Kosongkan map pelacak
            detailKeHeaderMap.Clear();

            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Gunakan 'using' untuk koneksi ---
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    // --- PERBAIKAN: Query baru ke tabel Header & Detail ---
                    string query = @"
                        SELECT 
                            D.ID_Detail_Peminjaman, 
                            H.ID_Peminjaman, 
                            B.Nama_Barang, 
                            D.Jumlah, 
                            H.Tgl_Pinjam, 
                            H.Tgl_JatuhTempo
                        FROM tblPeminjaman_Detail D
                        JOIN tblPeminjaman_Header H ON D.ID_Peminjaman = H.ID_Peminjaman
                        JOIN tblBarang B ON D.ID_Barang = B.ID_Barang
                        WHERE 
                            H.Status = 'Dipinjam' AND " +
                            (tipePeminjam == "Guru" ? "H.ID_Guru_Peminjam = @id" : "H.ID_Siswa_Peminjam = @id");

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@id", idPeminjamTerpilih);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dgvBarangDipinjam.DataSource = dt;
                        btnProsesPengembalian.Enabled = dt.Rows.Count > 0;

                        // Simpan relasi ID Detail -> ID Header untuk proses pengembalian
                        foreach (DataRow row in dt.Rows)
                        {
                            detailKeHeaderMap[Convert.ToInt32(row["ID_Detail_Peminjaman"])] = Convert.ToInt32(row["ID_Peminjaman"]);
                        }

                        // Pastikan kolom diatur setelah data terisi
                        if (dgvBarangDipinjam.Columns.Contains("ID_Detail_Peminjaman"))
                            dgvBarangDipinjam.Columns["ID_Detail_Peminjaman"].Visible = false;
                        if (dgvBarangDipinjam.Columns.Contains("ID_Peminjaman"))
                            dgvBarangDipinjam.Columns["ID_Peminjaman"].Visible = false; // Sembunyikan ID Header juga
                        if (dgvBarangDipinjam.Columns.Contains("Nama_Barang"))
                            dgvBarangDipinjam.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                // --- PERBAIKAN: Notifikasi Profesional ---
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar barang dipinjam. Hubungi administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBarangDipinjam.DataSource = null;
                    btnProsesPengembalian.Enabled = false;
                }
            } // 'conn' otomatis ditutup
        }

        // --- PEROMBAKAN BESAR DI SINI ---
        private void btnProsesPengembalian_Click(object sender, EventArgs e)
        {
            List<int> idDetailDipilih = new List<int>();

            foreach (DataGridViewRow row in dgvBarangDipinjam.Rows)
            {
                if (row.IsNewRow) continue;

                DataGridViewCheckBoxCell chk = row.Cells["colPilih"] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && Convert.ToBoolean(chk.Value) == true)
                {
                    idDetailDipilih.Add(Convert.ToInt32(row.Cells["ID_Detail_Peminjaman"].Value));
                }
            }

            if (idDetailDipilih.Count == 0)
            {
                MessageBox.Show("Pilih setidaknya satu barang untuk dikembalikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Proses pengembalian {idDetailDipilih.Count} barang yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

                    HashSet<int> headerIDsTerkait = new HashSet<int>();

                    foreach (int idDetail in idDetailDipilih)
                    {
                        int idBarang = 0;
                        int jumlah = 0;
                        int idHeader = detailKeHeaderMap[idDetail];
                        headerIDsTerkait.Add(idHeader);

                        // 1. Ambil detail barang dari tblPeminjaman_Detail
                        using (SqlCommand cmdGetDetails = new SqlCommand("SELECT ID_Barang, Jumlah FROM tblPeminjaman_Detail WHERE ID_Detail_Peminjaman = @idDetail", conn, transaction))
                        {
                            cmdGetDetails.Parameters.AddWithValue("@idDetail", idDetail);
                            using (SqlDataReader reader = cmdGetDetails.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idBarang = reader.GetInt32(0);
                                    jumlah = reader.GetInt32(1);
                                }
                            }
                        }

                        if (idBarang == 0) continue;

                        // 2. Kembalikan stok ke tblBarang
                        using (SqlCommand cmdUpdateStok = new SqlCommand("UPDATE tblBarang SET Stok = Stok + @jumlah WHERE ID_Barang = @idBarang", conn, transaction))
                        {
                            cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah);
                            cmdUpdateStok.Parameters.AddWithValue("@idBarang", idBarang);
                            cmdUpdateStok.ExecuteNonQuery();
                        }

                        // 3. Hapus item dari tblPeminjaman_Detail
                        using (SqlCommand cmdDeleteDetail = new SqlCommand("DELETE FROM tblPeminjaman_Detail WHERE ID_Detail_Peminjaman = @idDetail", conn, transaction))
                        {
                            cmdDeleteDetail.Parameters.AddWithValue("@idDetail", idDetail);
                            cmdDeleteDetail.ExecuteNonQuery();
                        }
                    }

                    // 4. Cek setiap Header yang terpengaruh
                    foreach (int idHeader in headerIDsTerkait)
                    {
                        int sisaItem = 0;
                        // Cek apakah masih ada item tersisa
                        using (SqlCommand cmdCekSisa = new SqlCommand("SELECT COUNT(*) FROM tblPeminjaman_Detail WHERE ID_Peminjaman = @idHeader", conn, transaction))
                        {
                            cmdCekSisa.Parameters.AddWithValue("@idHeader", idHeader);
                            sisaItem = (int)cmdCekSisa.ExecuteScalar();
                        }

                        // 5. Jika tidak ada item tersisa, update status Header
                        if (sisaItem == 0)
                        {
                            using (SqlCommand cmdUpdateHeader = new SqlCommand("UPDATE tblPeminjaman_Header SET Status = 'Sudah Kembali', Tgl_Kembali = @tgl WHERE ID_Peminjaman = @idHeader", conn, transaction))
                            {
                                cmdUpdateHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                                cmdUpdateHeader.Parameters.AddWithValue("@idHeader", idHeader);
                                cmdUpdateHeader.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Pengembalian barang berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                catch (SqlException sqlEx)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal memproses pengembalian. Terjadi masalah database.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal memproses pengembalian. Terjadi kesalahan sistem.", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TampilkanBarangDipinjam(); // Refresh DataGridView
        }

        // --- (Metode lain tidak berubah) ---

        private void dgvBarangDipinjam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // (Kode CellFormatting Anda sudah bagus, tidak perlu diubah)
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvBarangDipinjam.Columns.Contains("Tgl_JatuhTempo"))
            {
                var cellValue = dgvBarangDipinjam.Rows[e.RowIndex].Cells["Tgl_JatuhTempo"].Value;

                if (cellValue != DBNull.Value && cellValue != null)
                {
                    DateTime tglJatuhTempo = Convert.ToDateTime(cellValue);
                    if (tglJatuhTempo.Date < DateTime.Now.Date)
                    {
                        dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {
                    dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvBarangDipinjam.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTutup_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyPengembalianChanged();
        }

        public void RefreshPeminjamData()
        {
            if (idPeminjamTerpilih != null)
            {
                TampilkanBarangDipinjam();
            }
        }
    }
}