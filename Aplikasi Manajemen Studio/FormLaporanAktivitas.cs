using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text; // Untuk Ekspor CSV
using System.IO; // Untuk Ekspor CSV
using System.Linq; // Untuk Ekspor CSV
using System.Collections.Generic; // Untuk Ekspor CSV
// --- TAMBAHKAN 'using' DI BAWAH INI UNTUK PDF ---
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics; // Untuk membuka file PDF
using System.Globalization; // <-- TAMBAHKAN INI UNTUK TANGGAL INDONESIA

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormLaporanAktivitas : Form
    {
        private string idPetugasLogin;

        // Variabel Filter untuk Tab Peminjaman
        private string filterIdPeminjam_Pinjam = null;
        private string filterPeminjamType_Pinjam = "Semua";

        // Variabel Filter untuk Tab Permintaan
        private string filterIdPemohon_Minta = null;
        private string filterPemohonType_Minta = "Semua";

        public FormLaporanAktivitas(string jabatan, string idPetugasLogin)
        {
            InitializeComponent();
            this.idPetugasLogin = idPetugasLogin;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormLaporanAktivitas_Load(object sender, EventArgs e)
        {
            // Inisialisasi semua filter saat form dimuat
            InisialisasiFilterPeminjaman();
            InisialisasiFilterPermintaan();
            InisialisasiFilterPembelian();

            // Memuat data awal untuk tab yang aktif (Peminjaman)
            LoadLaporanPeminjaman();

            // Hubungkan tombol Cetak ke event handler-nya
            // (Anda mungkin sudah melakukan ini di desainer)
            // --- HAPUS ATAU KOMENTARI 3 BARIS DI BAWAH INI ---
            // this.btnCetak_Pinjam.Click += new System.EventHandler(this.btnCetak_Pinjam_Click);
            // this.btnCetak_Minta.Click += new System.EventHandler(this.btnCetak_Minta_Click);
            // this.btnCetak_Beli.Click += new System.EventHandler(this.btnCetak_Beli_Click);
        }

        // ========================================================================
        // --- BAGIAN UMUM & HELPER ---
        // ========================================================================

        private void EksporDGVKeCsv(DataGridView dgv, string namaFileDefault)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"{namaFileDefault}_{DateTime.Now:yyyyMMdd}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    var headers = dgv.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => $"\"{column.HeaderText}\"").ToArray()));

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => $"\"{cell.Value}\"").ToArray()));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Laporan berhasil diekspor!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor data. Hubungi administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- METODE CETAK PDF (DIPERBARUI) ---
        private void CetakDGVKePdf(DataGridView dgv, string judulLaporan)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File (*.pdf)|*.pdf";
            sfd.FileName = $"{judulLaporan}_{DateTime.Now:yyyyMMdd}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Setup Dokumen PDF (Landscape A4)
                    Document doc = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // 2. Tambahkan Judul dan Tanggal
                    iTextSharp.text.Font fontJudul = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    iTextSharp.text.Font fontSubJudul = FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.ITALIC);
                    iTextSharp.text.Font fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    iTextSharp.text.Font fontCell = FontFactory.GetFont(FontFactory.HELVETICA, 9);

                    doc.Add(new Paragraph(judulLaporan, fontJudul) { Alignment = Element.ALIGN_CENTER });

                    // --- PERBAIKAN 1: TANGGAL BAHASA INDONESIA ---
                    CultureInfo ci = new CultureInfo("id-ID");
                    string tanggalCetak = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm", ci);
                    doc.Add(new Paragraph($"Dicetak pada: {tanggalCetak} WIB", fontSubJudul) { Alignment = Element.ALIGN_CENTER });
                    // ---------------------------------------------

                    doc.Add(Chunk.NEWLINE); // Spasi

                    // 3. Buat Tabel PDF
                    int visibleColumnCount = dgv.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
                    PdfPTable table = new PdfPTable(visibleColumnCount);
                    table.WidthPercentage = 100;

                    // 4. Tambahkan Header Kolom
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (!col.Visible) continue;
                        PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fontHeader));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // 5. Tambahkan Baris Data
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (!dgv.Columns[cell.ColumnIndex].Visible) continue;
                            table.AddCell(new Phrase(cell.FormattedValue.ToString(), fontCell));
                        }
                    }

                    // 6. Tambahkan tabel ke dokumen dan tutup
                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("Laporan PDF berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- PERBAIKAN 2: PERBAIKAN BUG Win32Exception ---
                    // Menggunakan ProcessStartInfo untuk cara membuka file yang lebih aman
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true // Ini akan bertindak seperti double-click
                    };
                    Process.Start(psi);
                    // -----------------------------------------------
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("Gagal menyimpan PDF. Pastikan file tidak sedang dibuka oleh program lain.", "Error I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat PDF. Hubungi administrator.\nError: " + ex.GetType().Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Event Handler Tombol Cetak ---
        private void btnCetak_Pinjam_Click(object sender, EventArgs e)
        {
            CetakDGVKePdf(dgvLaporanPeminjaman, "Laporan_Peminjaman_Barang");
        }

        private void btnCetak_Minta_Click(object sender, EventArgs e)
        {
            CetakDGVKePdf(dgvLaporanPermintaan, "Laporan_Permintaan_Barang");
        }

        private void btnCetak_Beli_Click(object sender, EventArgs e)
        {
            CetakDGVKePdf(dgvLaporanPembelian, "Laporan_Pembelian_Barang");
        }

        // ========================================================================
        // --- TAB 1: LAPORAN PEMINJAMAN ---
        // ========================================================================

        private void InisialisasiFilterPeminjaman()
        {
            dtpDari_Pinjam.Value = DateTime.Now.AddMonths(-1);
            dtpHingga_Pinjam.Value = DateTime.Now;
            cmbStatus_Pinjam.Items.Clear();
            cmbStatus_Pinjam.Items.AddRange(new object[] { "Semua", "Dipinjam", "Sudah Kembali", "Terlambat", "Pending", "Ditolak" });
            cmbStatus_Pinjam.SelectedIndex = 0;
            rbSemua_Pinjam.Checked = true;
            txtPeminjam_Pinjam.Text = "Semua Peminjam";
            filterIdPeminjam_Pinjam = null;
            SetPeminjamFilterControlsState_Pinjam();
        }

        private void SetPeminjamFilterControlsState_Pinjam()
        {
            bool enableSearch = !rbSemua_Pinjam.Checked;
            txtPeminjam_Pinjam.Enabled = enableSearch;
            btnCari_Pinjam.Enabled = enableSearch;
            if (!enableSearch) txtPeminjam_Pinjam.Text = "Semua Peminjam";
        }

        private void rbPeminjam_Pinjam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGuru_Pinjam.Checked) filterPeminjamType_Pinjam = "Guru";
            else if (rbSiswa_Pinjam.Checked) filterPeminjamType_Pinjam = "Siswa";
            else filterPeminjamType_Pinjam = "Semua";
            filterIdPeminjam_Pinjam = null;
            SetPeminjamFilterControlsState_Pinjam();
        }

        private void btnCari_Pinjam_Click(object sender, EventArgs e)
        {
            if (filterPeminjamType_Pinjam == "Guru")
            {
                using (FormCariGuru frm = new FormCariGuru())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        filterIdPeminjam_Pinjam = frm.SelectedGuruID;
                        txtPeminjam_Pinjam.Text = frm.SelectedGuruNama;
                    }
                }
            }
            else if (filterPeminjamType_Pinjam == "Siswa")
            {
                using (FormCariSiswa frm = new FormCariSiswa())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        filterIdPeminjam_Pinjam = frm.SelectedSiswaID;
                        txtPeminjam_Pinjam.Text = frm.SelectedSiswaNama;
                    }
                }
            }
        }

        private void btnTampil_Pinjam_Click(object sender, EventArgs e)
        {
            LoadLaporanPeminjaman();
        }

        private void btnReset_Pinjam_Click(object sender, EventArgs e)
        {
            InisialisasiFilterPeminjaman();
            LoadLaporanPeminjaman();
        }

        private void btnEkspor_Pinjam_Click(object sender, EventArgs e)
        {
            EksporDGVKeCsv(dgvLaporanPeminjaman, "Laporan_Peminjaman");
        }

        private void LoadLaporanPeminjaman()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT H.Tgl_Pinjam, H.Tgl_Kembali, H.Tgl_JatuhTempo,
                                        B.Nama_Barang, D.Jumlah, 
                                        ISNULL(g.Nama_Guru, s.Nama_Siswa) AS Peminjam, H.Status
                                   FROM tblPeminjaman_Detail D
                                   JOIN tblPeminjaman_Header H ON D.ID_Peminjaman = H.ID_Peminjaman
                                   JOIN tblBarang B ON D.ID_Barang = B.ID_Barang
                                   LEFT JOIN tblGuru g ON H.ID_Guru_Peminjam = g.ID_Guru
                                   LEFT JOIN tblSiswa s ON H.ID_Siswa_Peminjam = s.ID_Siswa
                                   WHERE H.Tgl_Pinjam BETWEEN @tglDari AND @tglHingga";

                    if (cmbStatus_Pinjam.SelectedItem.ToString() == "Terlambat")
                        query += " AND H.Status = 'Dipinjam' AND H.Tgl_JatuhTempo < GETDATE()";
                    else if (cmbStatus_Pinjam.SelectedItem.ToString() != "Semua")
                        query += " AND H.Status = @status";

                    if (filterIdPeminjam_Pinjam != null)
                        query += (filterPeminjamType_Pinjam == "Guru" ? " AND H.ID_Guru_Peminjam = @idPeminjam" : " AND H.ID_Siswa_Peminjam = @idPeminjam");

                    query += " ORDER BY H.Tgl_Pinjam DESC";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@tglDari", dtpDari_Pinjam.Value.Date);
                        sda.SelectCommand.Parameters.AddWithValue("@tglHingga", dtpHingga_Pinjam.Value.Date.AddDays(1).AddTicks(-1));
                        if (cmbStatus_Pinjam.SelectedItem.ToString() != "Semua" && cmbStatus_Pinjam.SelectedItem.ToString() != "Terlambat")
                            sda.SelectCommand.Parameters.AddWithValue("@status", cmbStatus_Pinjam.SelectedItem.ToString());
                        if (filterIdPeminjam_Pinjam != null)
                            sda.SelectCommand.Parameters.AddWithValue("@idPeminjam", filterIdPeminjam_Pinjam);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvLaporanPeminjaman.DataSource = dt;

                        // --- PERBAIKAN: MENAMBAHKAN KEMBALI AutoSizeMode ---
                        dgvLaporanPeminjaman.Columns["Tgl_Pinjam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPeminjaman.Columns["Tgl_Kembali"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPeminjaman.Columns["Tgl_JatuhTempo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPeminjaman.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPeminjaman.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPeminjaman.Columns["Peminjam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPeminjaman.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat laporan peminjaman. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================================================
        // --- TAB 2: LAPORAN PERMINTAAN (BARANG KELUAR) ---
        // ========================================================================
        private void InisialisasiFilterPermintaan()
        {
            dtpDari_Minta.Value = DateTime.Now.AddMonths(-1);
            dtpHingga_Minta.Value = DateTime.Now;
            rbSemua_Minta.Checked = true;
            txtPemohon_Minta.Text = "Semua Pemohon";
            filterIdPemohon_Minta = null;
            SetPemohonFilterControlsState_Minta();
        }

        private void SetPemohonFilterControlsState_Minta()
        {
            bool enableSearch = !rbSemua_Minta.Checked;
            txtPemohon_Minta.Enabled = enableSearch;
            btnCari_Minta.Enabled = enableSearch;
            if (!enableSearch) txtPemohon_Minta.Text = "Semua Pemohon";
        }

        private void rbPemohon_Minta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGuru_Minta.Checked) filterPemohonType_Minta = "Guru";
            else if (rbSiswa_Minta.Checked) filterPemohonType_Minta = "Siswa";
            else filterPemohonType_Minta = "Semua";
            filterIdPemohon_Minta = null;
            SetPemohonFilterControlsState_Minta();
        }

        private void btnCari_Minta_Click(object sender, EventArgs e)
        {
            if (filterPemohonType_Minta == "Guru")
            {
                using (FormCariGuru frm = new FormCariGuru())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        filterIdPemohon_Minta = frm.SelectedGuruID;
                        txtPemohon_Minta.Text = frm.SelectedGuruNama;
                    }
                }
            }
            else if (filterPemohonType_Minta == "Siswa")
            {
                using (FormCariSiswa frm = new FormCariSiswa())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        filterIdPemohon_Minta = frm.SelectedSiswaID;
                        txtPemohon_Minta.Text = frm.SelectedSiswaNama;
                    }
                }
            }
        }

        private void btnTampil_Minta_Click(object sender, EventArgs e) { LoadLaporanPermintaan(); }
        private void btnReset_Minta_Click(object sender, EventArgs e) { InisialisasiFilterPermintaan(); LoadLaporanPermintaan(); }
        private void btnEkspor_Minta_Click(object sender, EventArgs e) { EksporDGVKeCsv(dgvLaporanPermintaan, "Laporan_Permintaan"); }

        private void LoadLaporanPermintaan()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT h.Tgl_Permintaan, ISNULL(g.Nama_Guru, s.Nama_Siswa) AS Pemohon,
                                       b.Nama_Barang, d.Jumlah_Diminta, pet.Nama_Lengkap AS [Petugas Pencatat]
                                     FROM tblPermintaan_Header h
                                     JOIN tblPermintaan_Detail d ON h.ID_Permintaan = d.ID_Permintaan
                                     JOIN tblBarang b ON d.ID_Barang = b.ID_Barang
                                     JOIN tblPetugas pet ON h.ID_Petugas = pet.ID_Petugas
                                     LEFT JOIN tblGuru g ON h.ID_Guru_Peminta = g.ID_Guru
                                     LEFT JOIN tblSiswa s ON h.ID_Siswa_Peminta = s.ID_Siswa
                                     WHERE h.Tgl_Permintaan BETWEEN @tglDari AND @tglHingga
                                     AND h.Status = 'Disetujui'";

                    if (filterIdPemohon_Minta != null)
                        query += (filterPemohonType_Minta == "Guru" ? " AND h.ID_Guru_Peminta = @idPemohon" : " AND h.ID_Siswa_Peminta = @idPemohon");
                    query += " ORDER BY h.Tgl_Permintaan DESC";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@tglDari", dtpDari_Minta.Value.Date);
                        sda.SelectCommand.Parameters.AddWithValue("@tglHingga", dtpHingga_Minta.Value.Date.AddDays(1).AddTicks(-1));
                        if (filterIdPemohon_Minta != null)
                            sda.SelectCommand.Parameters.AddWithValue("@idPemohon", filterIdPemohon_Minta);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvLaporanPermintaan.DataSource = dt;

                        // --- PERBAIKAN: MENAMBAHKAN KEMBALI AutoSizeMode ---
                        dgvLaporanPermintaan.Columns["Tgl_Permintaan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPermintaan.Columns["Pemohon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPermintaan.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPermintaan.Columns["Jumlah_Diminta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPermintaan.Columns["Petugas Pencatat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat laporan permintaan. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================================================
        // --- TAB 3: LAPORAN PEMBELIAN (BARANG MASUK) ---
        // ========================================================================

        private void InisialisasiFilterPembelian()
        {
            dtpDari_Beli.Value = DateTime.Now.AddMonths(-1);
            dtpHingga_Beli.Value = DateTime.Now;
            txtPemasok_Beli.Clear();
            LoadBarangKeComboBox_Beli();
        }

        private void LoadBarangKeComboBox_Beli()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT ID_Barang, Nama_Barang FROM tblBarang ORDER BY Nama_Barang", conn);
                    DataTable dt = new DataTable(); sda.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["ID_Barang"] = 0;
                    dr["Nama_Barang"] = "Semua Barang";
                    dt.Rows.InsertAt(dr, 0);
                    cmbBarang_Beli.DataSource = dt;
                    cmbBarang_Beli.DisplayMember = "Nama_Barang";
                    cmbBarang_Beli.ValueMember = "ID_Barang";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data barang untuk filter. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTampil_Beli_Click(object sender, EventArgs e) { LoadLaporanPembelian(); }
        private void btnReset_Beli_Click(object sender, EventArgs e) { InisialisasiFilterPembelian(); LoadLaporanPembelian(); }
        private void btnEkspor_Beli_Click(object sender, EventArgs e) { EksporDGVKeCsv(dgvLaporanPembelian, "Laporan_Pembelian"); }

        private void LoadLaporanPembelian()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.Tgl_Pembelian, p.No_Faktur, p.Nama_Pemasok, 
                                       b.Nama_Barang, p.Jumlah, p.Harga_Satuan, 
                                       (p.Jumlah * p.Harga_Satuan) AS Total_Harga, 
                                       pet.Nama_Lengkap AS [Petugas Pencatat]
                                     FROM tblPembelian p
                                     JOIN tblBarang b ON p.ID_Barang = b.ID_Barang
                                     JOIN tblPetugas pet ON p.ID_Petugas = pet.ID_Petugas
                                     WHERE p.Tgl_Pembelian BETWEEN @tglDari AND @tglHingga";

                    if (!string.IsNullOrEmpty(txtPemasok_Beli.Text))
                        query += " AND p.Nama_Pemasok LIKE @pemasok";
                    if (Convert.ToInt32(cmbBarang_Beli.SelectedValue) > 0)
                        query += " AND p.ID_Barang = @idBarang";
                    query += " ORDER BY p.Tgl_Pembelian DESC";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@tglDari", dtpDari_Beli.Value.Date);
                        sda.SelectCommand.Parameters.AddWithValue("@tglHingga", dtpHingga_Beli.Value.Date.AddDays(1).AddTicks(-1));
                        if (!string.IsNullOrEmpty(txtPemasok_Beli.Text))
                            sda.SelectCommand.Parameters.AddWithValue("@pemasok", "%" + txtPemasok_Beli.Text + "%");
                        if (Convert.ToInt32(cmbBarang_Beli.SelectedValue) > 0)
                            sda.SelectCommand.Parameters.AddWithValue("@idBarang", cmbBarang_Beli.SelectedValue);

                        DataTable dt = new DataTable(); sda.Fill(dt);
                        dgvLaporanPembelian.DataSource = dt;

                        // --- PERBAIKAN: MENAMBAHKAN KEMBALI AutoSizeMode ---
                        dgvLaporanPembelian.Columns["Tgl_Pembelian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPembelian.Columns["No_Faktur"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPembelian.Columns["Nama_Pemasok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPembelian.Columns["Nama_Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvLaporanPembelian.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPembelian.Columns["Harga_Satuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPembelian.Columns["Total_Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLaporanPembelian.Columns["Petugas Pencatat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat laporan pembelian. Hubungi administrator.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Event Handler Tambahan ---
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        // --- Metode Refresh (sudah bagus) ---
        public void RefreshPeminjamanTab()
        {
            if (tabControlLaporan.SelectedTab == tabPagePeminjaman)
            {
                LoadLaporanPeminjaman();
            }
        }

        public void RefreshPermintaanTab()
        {
            if (tabControlLaporan.SelectedTab == tabPagePermintaan)
            {
                LoadLaporanPermintaan();
            }
        }

        public void RefreshPembelianTab()
        {
            if (tabControlLaporan.SelectedTab == tabPagePembelian)
            {
                LoadLaporanPembelian();
            }
        }

        public void RefreshAllTabsData()
        {
            if (tabControlLaporan.SelectedTab == tabPagePeminjaman) LoadLaporanPeminjaman();
            else if (tabControlLaporan.SelectedTab == tabPagePermintaan) LoadLaporanPermintaan();
            else if (tabControlLaporan.SelectedTab == tabPagePembelian) LoadLaporanPembelian();
        }
    }
}