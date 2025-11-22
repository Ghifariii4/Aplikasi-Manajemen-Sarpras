using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Aplikasi_Manajemen_Studio.Properties;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormPermintaan : Form
    {
        private string idPemohonTerpilih = null;
        private string tipePemohon = "Guru";
        private string idPetugasPencatat;
        private string userJabatan; // <--- TAMBAHAN: Untuk menyimpan jabatan

        private DataTable dtKeranjang = new DataTable();

        // --- PERBAIKAN: Konstruktor diupdate untuk menerima 'jabatan' ---
        public FormPermintaan(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasPencatat = idPetugasLogin;
            this.userJabatan = jabatan; // <--- Simpan jabatan pengguna

            // Sembunyikan tombol berdasarkan jabatan (meskipun ini lebih relevan di form manajemen)
            // if (this.userJabatan != "Kepala Sarpras")
            // {
            //     // Sembunyikan tombol "Setuju" jika ada di sini
            // }

            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormPermintaan_Load(object sender, EventArgs e)
        {
            SetupKeranjang();
            LoadBarangKeComboBox();
            KondisiAwal();
        }

        // --- Metode Pengaturan UI & Data Awal ---

        private void SetupKeranjang()
        {
            // ... (Kode SetupKeranjang Anda sudah bagus, tidak perlu diubah) ...
            dtKeranjang.Columns.Add("ID_Barang", typeof(int));
            dtKeranjang.Columns.Add("Nama_Barang", typeof(string));
            dtKeranjang.Columns.Add("Jumlah", typeof(int));

            dgvKeranjang.DataSource = dtKeranjang;

            if (dgvKeranjang.Columns["colHapus"] == null)
            {
                DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
                colHapus.Name = "colHapus";
                colHapus.HeaderText = "Aksi";
                colHapus.Text = "Hapus";
                colHapus.UseColumnTextForButtonValue = true;
                dgvKeranjang.Columns.Add(colHapus);
            }

            dgvKeranjang.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKeranjang.Columns["ID_Barang"].Visible = false;
        }

        private void LoadBarangKeComboBox()
        {
            Koneksi kon = new Koneksi();
            // --- PERBAIKAN: Menggunakan 'using' untuk manajemen koneksi otomatis ---
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
                    MessageBox.Show("Gagal memuat data barang. Terjadi kesalahan koneksi atau query.\nSilakan hubungi administrator.",
                                    "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // (Opsional: log ex.Message ke file untuk debugging)
                }
            } // 'conn' otomatis ditutup di sini, bahkan jika terjadi error
        }

        private void KondisiAwal()
        {
            rbGuru.Checked = true;
            idPemohonTerpilih = null;
            txtNamaPemohon.Text = "";
            cmbBarang.SelectedIndex = -1;
            numJumlah.Value = 1;
            dtKeranjang.Clear();
            UpdateTotalBarang();

            btnDetailTransaksi.Enabled = false;
        }

        private void UpdateTotalBarang()
        {
            lblTotalBarang.Text = $"{dtKeranjang.Rows.Count}";
        }

        // --- Event Handler ---

        private void rbGuru_Siswa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGuru.Checked) tipePemohon = "Guru";
            if (rbSiswa.Checked) tipePemohon = "Siswa";
            idPemohonTerpilih = null;
            txtNamaPemohon.Text = "";
        }

        private void btnCariPemohon_Click(object sender, EventArgs e)
        {
            // ... (Kode ini sudah bagus, 'using' sudah dipakai) ...
            if (tipePemohon == "Guru")
            {
                using (FormCariGuru frm = new FormCariGuru())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        idPemohonTerpilih = frm.SelectedGuruID;
                        txtNamaPemohon.Text = frm.SelectedGuruNama;
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
                        txtNamaPemohon.Text = frm.SelectedSiswaNama;
                    }
                }
            }
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            // ... (Kode ini sudah bagus, tidak perlu diubah) ...
            if (cmbBarang.SelectedIndex == -1 || numJumlah.Value <= 0)
            {
                MessageBox.Show("Silakan pilih barang dan tentukan jumlahnya.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idBarang = Convert.ToInt32(cmbBarang.SelectedValue);
            string namaBarang = ((DataRowView)cmbBarang.SelectedItem)["TampilanBarang"].ToString();
            int jumlah = (int)numJumlah.Value;

            foreach (DataRow row in dtKeranjang.Rows)
            {
                if (Convert.ToInt32(row["ID_Barang"]) == idBarang)
                {
                    row["Jumlah"] = Convert.ToInt32(row["Jumlah"]) + jumlah;
                    UpdateTotalBarang();
                    return;
                }
            }
            dtKeranjang.Rows.Add(idBarang, namaBarang, jumlah);
            UpdateTotalBarang();
        }

        private void dgvKeranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ... (Kode ini sudah bagus, tidak perlu diubah) ...
            if (e.ColumnIndex == dgvKeranjang.Columns["colHapus"].Index && e.RowIndex >= 0)
            {
                dtKeranjang.Rows.RemoveAt(e.RowIndex);
                UpdateTotalBarang();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        // --- PERUBAHAN BESAR DI SINI ---
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (idPemohonTerpilih == null)
            {
                MessageBox.Show("Silakan pilih pemohon terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong. Silakan tambahkan barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // --- PERBAIKAN: 'Status' tidak perlu di-insert, akan otomatis 'Pending' dari DB Default ---
                    string queryHeader = "INSERT INTO tblPermintaan_Header (Tgl_Permintaan, ID_Guru_Peminta, ID_Siswa_Peminta, ID_Petugas) OUTPUT INSERTED.ID_Permintaan VALUES (@tgl, @idGuru, @idSiswa, @idPetugas)";

                    int idPermintaanHeader;
                    using (SqlCommand cmdHeader = new SqlCommand(queryHeader, conn, transaction))
                    {
                        cmdHeader.Parameters.AddWithValue("@tgl", DateTime.Now);
                        cmdHeader.Parameters.AddWithValue("@idPetugas", this.idPetugasPencatat);
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
                        idPermintaanHeader = (int)cmdHeader.ExecuteScalar();
                    }


                    foreach (DataRow row in dtKeranjang.Rows)
                    {
                        int idBarang = Convert.ToInt32(row["ID_Barang"]);
                        int jumlah = Convert.ToInt32(row["Jumlah"]);

                        // --- VALIDASI STOK (PENTING!) ---
                        // Kita tetap cek stok agar pengguna tidak bisa minta lebih dari yang ada
                        int stokSaatIni = 0;
                        using (SqlCommand cmdCekStok = new SqlCommand("SELECT Stok FROM tblBarang WHERE ID_Barang = @id", conn, transaction))
                        {
                            cmdCekStok.Parameters.AddWithValue("@id", idBarang);
                            stokSaatIni = (int)cmdCekStok.ExecuteScalar();
                        }

                        if (stokSaatIni < jumlah)
                        {
                            // Jika stok tidak cukup, batalkan semua (rollback)
                            throw new Exception($"Stok untuk '{row["Nama_Barang"]}' tidak mencukupi (sisa {stokSaatIni})!");
                        }

                        // --- DIHAPUS ---
                        // Perintah 'UPDATE tblBarang SET Stok = Stok - @jml' DIHAPUS.
                        // Pengurangan stok hanya terjadi saat Admin menyetujui.
                        // --- DIHAPUS ---

                        // Masukkan ke detail permintaan
                        using (SqlCommand cmdDetail = new SqlCommand("INSERT INTO tblPermintaan_Detail (ID_Permintaan, ID_Barang, Jumlah_Diminta) VALUES (@idHeader, @idBrg, @jml)", conn, transaction))
                        {
                            cmdDetail.Parameters.AddWithValue("@idHeader", idPermintaanHeader);
                            cmdDetail.Parameters.AddWithValue("@idBrg", idBarang);
                            cmdDetail.Parameters.AddWithValue("@jml", jumlah);
                            cmdDetail.ExecuteNonQuery();
                        }
                    }

                    // Jika semua berhasil, commit transaksi
                    transaction.Commit();
                    MessageBox.Show("Permintaan berhasil diajukan dan menunggu persetujuan Admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NotifyParentForm();
                    KondisiAwal();
                    LoadBarangKeComboBox(); // Muat ulang barang, mungkin stoknya berubah
                }
                // --- PERBAIKAN: Notifikasi Error Profesional ---
                catch (SqlException sqlEx)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Gagal menyimpan permintaan. Terjadi masalah pada database.\nSilakan hubungi administrator.",
                                    "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Menangkap error stok tidak cukup dari 'throw new Exception' di atas
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Permintaan Gagal: \n" + ex.Message,
                                    "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } // 'conn' otomatis ditutup di sini
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fungsi ini untuk melihat detail transaksi yang sudah disimpan. " +
                            "Biasanya diaktifkan dari form Laporan atau Riwayat Transaksi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Metode Helper (sudah bagus) ---
        private void NotifyParentForm()
        {
            if (this.MdiParent is Menu_Utama parent) parent.NotifyPermintaanChanged();
        }

        public void ReloadBarangComboBox()
        {
            object selectedValue = cmbBarang.SelectedValue; // <-- PERBAIKAN
            LoadBarangKeComboBox();
            if (selectedValue != null) cmbBarang.SelectedValue = selectedValue;
        }
    }
}