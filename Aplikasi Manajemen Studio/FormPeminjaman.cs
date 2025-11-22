using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormPeminjaman : Form
    {
        private string idPemohonTerpilih = null;
        private string tipePemohon = "Guru";
        private string idPetugasPencatat;
        private string userJabatan; // <--- BARU
        private DateTime? hitungJatuhTempo;

        private DataTable dtKeranjang = new DataTable();

        public FormPeminjaman(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasPencatat = idPetugasLogin;
            this.userJabatan = jabatan; // <--- BARU
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            SetupKeranjang();
            LoadBarangKeComboBox();
            InisialisasiDurasiPeminjaman();
            KondisiAwal();
        }

        private void InisialisasiDurasiPeminjaman()
        {
            cmbSatuanDurasi.Items.Clear();
            cmbSatuanDurasi.Items.Add("Menit");
            cmbSatuanDurasi.Items.Add("Jam");
            cmbSatuanDurasi.Items.Add("Hari");
            cmbSatuanDurasi.Items.Add("Minggu");
            cmbSatuanDurasi.SelectedIndex = 1;
            numDurasi.Value = 1;
            numDurasi.Minimum = 1;
            // ... (sisa kode Inisialisasi Anda sudah bagus) ...
        }

        // --- Metode Pengaturan UI & Data Awal ---

        private void SetupKeranjang()
        {
            // ... (Kode SetupKeranjang Anda sudah bagus) ...
            dtKeranjang.Columns.Add("ID_Barang", typeof(int));
            dtKeranjang.Columns.Add("Nama_Barang", typeof(string));
            dtKeranjang.Columns.Add("Jumlah", typeof(int));
            dgvKeranjangPinjam.DataSource = dtKeranjang;

            if (dgvKeranjangPinjam.Columns["colHapus"] == null)
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.Name = "colHapus";
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.UseColumnTextForButtonValue = true;
                dgvKeranjangPinjam.Columns.Add(colHapus);
            }
            dgvKeranjangPinjam.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKeranjangPinjam.Columns["ID_Barang"].Visible = false;
        }

        private void LoadBarangKeComboBox()
        {
            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Gunakan 'using' untuk menutup celah koneksi ---
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Barang, (Nama_Barang + ' (Stok: ' + CAST(Stok AS VARCHAR) + ')') AS TampilanBarang FROM tblBarang WHERE Stok > 0 ORDER BY Nama_Barang";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmbBarang.DataSource = dt;
                    cmbBarang.DisplayMember = "TampilanBarang";
                    cmbBarang.ValueMember = "ID_Barang";
                }
                // --- PERBAIKAN: Notifikasi Error Profesional ---
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data barang. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup di sini
        }

        private void KondisiAwal()
        {
            rbGuru.Checked = true;
            idPemohonTerpilih = null;
            txtNamaPeminjam.Text = "";
            cmbBarang.SelectedIndex = -1;
            numJumlah.Value = 1;
            cmbSatuanDurasi.SelectedIndex = 1; // Default: Jam
            numDurasi.Value = 1;
            cbTanpaBatasWaktu.Checked = false;
            lblTglJatuhTempoOtomatis.Text = "-";
            hitungJatuhTempo = null;
            UpdateJatuhTempoLabel();
            dtKeranjang.Clear();
            UpdateTotalItems();
        }

        private void UpdateJatuhTempoLabel()
        {
            // ... (Logika UpdateJatuhTempoLabel Anda sudah bagus) ...
            // ... (Kita hanya perlu memastikan 'hitungJatuhTempo' terisi dengan benar) ...

            // (Kode Anda dari baris 112 - 177)
            if (cbTanpaBatasWaktu.Checked)
            {
                lblTglJatuhTempoOtomatis.Text = "Tanpa Batas Waktu";
                hitungJatuhTempo = null;
                return;
            }

            DateTime waktuPinjam = DateTime.Now;
            TimeSpan durasi = new TimeSpan();
            bool isValid = true;

            switch (cmbSatuanDurasi.SelectedItem.ToString())
            {
                case "Menit":
                    durasi = TimeSpan.FromMinutes((double)numDurasi.Value);
                    if (durasi < TimeSpan.FromMinutes(30)) { isValid = false; }
                    break;
                case "Jam":
                    durasi = TimeSpan.FromHours((double)numDurasi.Value);
                    if (durasi < TimeSpan.FromHours(1)) { isValid = false; }
                    break;
                case "Hari":
                    durasi = TimeSpan.FromDays((double)numDurasi.Value);
                    break;
                case "Minggu":
                    durasi = TimeSpan.FromDays((double)numDurasi.Value * 7);
                    break;
            }

            if (!isValid)
            {
                lblTglJatuhTempoOtomatis.Text = "Durasi Invalid";
                hitungJatuhTempo = null;
                return;
            }

            DateTime jatuhTempoTerhitung = waktuPinjam.Add(durasi);
            TimeSpan maxDurasiTotal = TimeSpan.FromDays(7);

            if (jatuhTempoTerhitung > waktuPinjam.Add(maxDurasiTotal))
            {
                MessageBox.Show("Durasi pinjam maksimal 1 minggu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblTglJatuhTempoOtomatis.Text = "Durasi terlalu lama";
                hitungJatuhTempo = null;
                return;
            }

            hitungJatuhTempo = jatuhTempoTerhitung;
            lblTglJatuhTempoOtomatis.Text = jatuhTempoTerhitung.ToString("dd MMMM yyyy HH:mm");
        }

        private void UpdateTotalItems()
        {
            lblTotalItem.Text = $"{dtKeranjang.Rows.Count}";
        }

        // --- Event Handler (Tidak banyak berubah) ---
        private void numDurasi_ValueChanged(object sender, EventArgs e) { UpdateJatuhTempoLabel(); }
        private void cmbSatuanDurasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ... (Logika cmbSatuanDurasi_SelectedIndexChanged Anda sudah bagus) ...
            string satuan = cmbSatuanDurasi.SelectedItem.ToString();
            if (satuan == "Menit") { numDurasi.Maximum = 60 * 24 * 7; }
            else if (satuan == "Jam") { numDurasi.Maximum = 24 * 7; }
            else if (satuan == "Hari") { numDurasi.Maximum = 7; }
            else if (satuan == "Minggu") { numDurasi.Maximum = 1; }
            if (numDurasi.Value > numDurasi.Maximum) numDurasi.Value = numDurasi.Maximum;
            UpdateJatuhTempoLabel();
        }
        private void cbTanpaBatasWaktu_CheckedChanged(object sender, EventArgs e)
        {
            numDurasi.Enabled = !cbTanpaBatasWaktu.Checked;
            cmbSatuanDurasi.Enabled = !cbTanpaBatasWaktu.Checked;
            UpdateJatuhTempoLabel();
        }
        private void rbGuru_Siswa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGuru.Checked) tipePemohon = "Guru";
            if (rbSiswa.Checked) tipePemohon = "Siswa";
            idPemohonTerpilih = null;
            txtNamaPeminjam.Text = "";
        }
        private void btnCariPeminjam_Click(object sender, EventArgs e)
        {
            // ... (Logika btnCariPeminjam_Click Anda sudah bagus) ...
            if (tipePemohon == "Guru")
            {
                using (FormCariGuru frm = new FormCariGuru())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        idPemohonTerpilih = frm.SelectedGuruID;
                        txtNamaPeminjam.Text = frm.SelectedGuruNama;
                    }
                }
            }
            else
            {
                using (FormCariSiswa frm = new FormCariSiswa())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        idPemohonTerpilih = frm.SelectedSiswaID;
                        txtNamaPeminjam.Text = frm.SelectedSiswaNama;
                    }
                }
            }
        }
        private void btnTambahKeKeranjang_Click(object sender, EventArgs e)
        {
            // ... (Logika btnTambahKeKeranjang_Click Anda sudah bagus) ...
            if (cmbBarang.SelectedIndex == -1 || numJumlah.Value <= 0) return;
            int idBarang = Convert.ToInt32(cmbBarang.SelectedValue);
            string namaBarang = ((DataRowView)cmbBarang.SelectedItem)["TampilanBarang"].ToString();
            int jumlah = (int)numJumlah.Value;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                if (Convert.ToInt32(row["ID_Barang"]) == idBarang)
                {
                    row["Jumlah"] = Convert.ToInt32(row["Jumlah"]) + jumlah;
                    UpdateTotalItems();
                    return;
                }
            }
            dtKeranjang.Rows.Add(idBarang, namaBarang, jumlah);
            UpdateTotalItems();
        }
        private void dgvKeranjangPinjam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKeranjangPinjam.Columns["colHapus"].Index && e.RowIndex >= 0)
            {
                dtKeranjang.Rows.RemoveAt(e.RowIndex);
                UpdateTotalItems();
            }
        }
        private void btnBatal_Click(object sender, EventArgs e) { KondisiAwal(); }


        // --- PERUBAHAN BESAR DI SINI ---
        private void btnSimpanPinjam_Click(object sender, EventArgs e)
        {
            if (idPemohonTerpilih == null || dtKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Harap pilih peminjam dan tambahkan barang ke keranjang.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateJatuhTempoLabel(); // Panggil validasi
            if (hitungJatuhTempo == null && !cbTanpaBatasWaktu.Checked)
            {
                MessageBox.Show("Durasi jatuh tempo yang dimasukkan tidak valid. Harap periksa kembali.", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // --- LOGIKA BARU: 1. Buat Header ---
                    string queryHeader = @"INSERT INTO tblPeminjaman_Header 
                                            (Tgl_Pinjam, Tgl_JatuhTempo, ID_Guru_Peminjam, ID_Siswa_Peminjam, ID_Petugas_Pencatat, Status)
                                            OUTPUT INSERTED.ID_Peminjaman 
                                            VALUES (@tgl, @tglJatuhTempo, @idGuru, @idSiswa, @idPetugas, 'Pending')";

                    int idPeminjamanHeader;
                    using (SqlCommand cmdHeader = new SqlCommand(queryHeader, conn, transaction))
                    {
                        cmdHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                        cmdHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPencatat);

                        // Atur Tgl_JatuhTempo
                        if (hitungJatuhTempo.HasValue)
                            cmdHeader.Parameters.AddWithValue("@tglJatuhTempo", hitungJatuhTempo.Value);
                        else
                            cmdHeader.Parameters.AddWithValue("@tglJatuhTempo", DBNull.Value);

                        // Atur Peminjam
                        if (tipePemohon == "Guru")
                        {
                            cmdHeader.Parameters.AddWithValue("@idGuru", idPemohonTerpilih);
                            cmdHeader.Parameters.AddWithValue("@idSiswa", DBNull.Value);
                        }
                        else
                        {
                            cmdHeader.Parameters.AddWithValue("@idGuru", DBNull.Value);
                            cmdHeader.Parameters.AddWithValue("@idSiswa", idPemohonTerpilih);
                        }

                        idPeminjamanHeader = (int)cmdHeader.ExecuteScalar();
                    }

                    // --- LOGIKA BARU: 2. Masukkan Detail ---
                    foreach (DataRow row in dtKeranjang.Rows)
                    {
                        int idBarang = Convert.ToInt32(row["ID_Barang"]);
                        int jumlah = Convert.ToInt32(row["Jumlah"]);

                        // --- DIHAPUS: Pengecekan stok dan pengurangan stok DIHAPUS dari sini ---
                        // (Admin akan melakukannya saat persetujuan)

                        // Masukkan ke detail peminjaman
                        string queryDetail = "INSERT INTO tblPeminjaman_Detail (ID_Peminjaman, ID_Barang, Jumlah) VALUES (@idHeader, @idBrg, @jml)";
                        using (SqlCommand cmdDetail = new SqlCommand(queryDetail, conn, transaction))
                        {
                            cmdDetail.Parameters.AddWithValue("@idHeader", idPeminjamanHeader);
                            cmdDetail.Parameters.AddWithValue("@idBrg", idBarang);
                            cmdDetail.Parameters.AddWithValue("@jml", jumlah);
                            cmdDetail.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Pengajuan peminjaman berhasil disimpan dan menunggu persetujuan Admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentForm();
                }
                // --- PERBAIKAN: Notifikasi Error Profesional ---
                catch (SqlException sqlEx)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyimpan pengajuan. Terjadi masalah pada database.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyimpan pengajuan: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup

            KondisiAwal();
            LoadBarangKeComboBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyPeminjamanChanged();
        }

        public void ReloadBarangComboBox()
        {
            object selectedValue = cmbBarang.SelectedValue;
            LoadBarangKeComboBox();
            if (selectedValue != null) cmbBarang.SelectedValue = selectedValue;
        }
    }
}