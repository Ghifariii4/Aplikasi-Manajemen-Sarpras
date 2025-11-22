using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Aplikasi_Manajemen_Studio;

namespace Aplikasi_Manajemen_Studio
{
    public partial class FormDashboard : Form
    {
        // Deklarasikan kartu-kartu di level class
        private InfoCard cardJenisBarang;
        private InfoCard cardTotalStok;
        private InfoCard cardPermintaanPending;
        private InfoCard cardStokKritis;

        public FormDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            InitializeInfoCards(); // Inisialisasi kartu
        }

        private void InitializeInfoCards()
        {
            // Pastikan flowLayoutPanelCards sudah ada di designer
            // dan bahwa instance card dibuat hanya sekali
            if (flowLayoutPanelCards.Controls.Count == 0) // Cegah duplikasi saat form di-load ulang
            {
                cardJenisBarang = new InfoCard();
                cardTotalStok = new InfoCard();
                cardPermintaanPending = new InfoCard();
                cardStokKritis = new InfoCard();

                // Tambahkan semua kartu ke FlowLayoutPanel
                flowLayoutPanelCards.Controls.Add(cardJenisBarang);
                flowLayoutPanelCards.Controls.Add(cardTotalStok);
                flowLayoutPanelCards.Controls.Add(cardPermintaanPending);
                flowLayoutPanelCards.Controls.Add(cardStokKritis);
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();

            if (this.MdiParent is Menu_Utama mainForm)
            {
                labelWelcomeUser.Text = $"Selamat Datang, {mainForm.LoggedInNamaPetugas}!";
            }
        }

        private void LoadDashboardData()
        {
            int totalJenisBarang = 0;
            int totalSeluruhStok = 0;
            int totalTransaksiHariIni = 0;
            int totalBarangStokKritis = 0;

            Koneksi kon = new Koneksi();
            SqlConnection conn = kon.GetConn();

            try
            {
                conn.Open();

                SqlCommand cmd;

                // Query 1: Total Jenis Barang
                cmd = new SqlCommand("SELECT COUNT(ID_Barang) FROM tblBarang", conn);
                totalJenisBarang = (int)cmd.ExecuteScalar();

                // Query 2: Total Stok Seluruh Barang
                cmd = new SqlCommand("SELECT COALESCE(SUM(Stok), 0) FROM tblBarang", conn);
                totalSeluruhStok = (int)cmd.ExecuteScalar();

                // Query 3: Total Permintaan Pending
                cmd = new SqlCommand("SELECT COUNT(ID_Permintaan) FROM tblPermintaan_Header WHERE CAST(Tgl_Permintaan AS DATE) = CAST(GETDATE() AS DATE)", conn);
                totalTransaksiHariIni = Convert.ToInt32(cmd.ExecuteScalar());

                // Query 4: Total Barang Stok Kritis (stok < 10)
                cmd = new SqlCommand("SELECT COUNT(ID_Barang) FROM tblBarang WHERE Stok < 10", conn);
                totalBarangStokKritis = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }

            // Update tampilan setiap kartu
            UpdateInfoCards(totalJenisBarang, totalSeluruhStok, totalTransaksiHariIni, totalBarangStokKritis);

            // Update tampilan notifikasi
            UpdateNotifications(totalTransaksiHariIni, totalBarangStokKritis);
        }

        private void UpdateInfoCards(int jenisBarang, int totalStok, int transaksiHariIni, int stokKritis)
        {
            // Pastikan InitializeInfoCards sudah dipanggil dan kartu sudah ada
            if (cardJenisBarang == null) InitializeInfoCards(); // Fallback jika belum terinisialisasi

            cardJenisBarang.CardTitle = "Jenis Barang Terdaftar";
            cardJenisBarang.CardValue = jenisBarang.ToString();
            cardJenisBarang.CardIcon = Properties.Resources.icon_inventory; // Ganti dengan nama resource Anda
            cardJenisBarang.CardColor = Color.FromArgb(0, 123, 255); // Biru (Bootstrap Primary)

            cardTotalStok.CardTitle = "Total Stok Barang";
            cardTotalStok.CardValue = totalStok.ToString();
            cardTotalStok.CardIcon = Properties.Resources.icon_stock; // Ganti dengan nama resource Anda
            cardTotalStok.CardColor = Color.FromArgb(23, 162, 184); // Teal (Bootstrap Info)

            cardPermintaanPending.CardTitle = "Aktivitas Hari Ini";
            cardPermintaanPending.CardValue = transaksiHariIni.ToString();
            cardPermintaanPending.CardIcon = Properties.Resources.icon_pending; // Ganti dengan nama resource Anda
            cardPermintaanPending.CardColor = Color.FromArgb(255, 193, 7); // Kuning (Bootstrap Warning)

            cardStokKritis.CardTitle = "Barang Stok Kritis";
            cardStokKritis.CardValue = stokKritis.ToString();
            cardStokKritis.CardIcon = Properties.Resources.icon_warning; // Ganti dengan nama resource Anda
            cardStokKritis.CardColor = Color.FromArgb(220, 53, 69); // Merah (Bootstrap Danger)
        }

        // Metode BARU untuk mengupdate Notifikasi
        private void UpdateNotifications(int transaksiHariIni, int barangStokKritis)
        {
            // Sembunyikan semua notifikasi spesifik dulu
            labelCriticalStockWarning.Visible = false;
            // Jika ada notifikasi lain, sembunyikan juga di sini

            string mainNotificationMessage = "";

            if (transaksiHariIni > 0 && barangStokKritis > 0)
            {
                //mainNotificationMessage = $"Ada {transaksiHariIni} tranbsaksi DAN {barangStokKritis} barang stok kritis.";
                labelNotification.ForeColor = Color.DarkRed;
                labelCriticalStockWarning.Text = $"Perhatian! Ada {barangStokKritis} barang dengan stok di bawah batas aman.";
                labelCriticalStockWarning.Visible = true;
            }
            else if (transaksiHariIni > 0)
            {
                mainNotificationMessage = $"Ada {transaksiHariIni} transaksi hari ini.";
                labelNotification.ForeColor = Color.DarkOrange; // Warna peringatan
            }
            else if (barangStokKritis > 0)
            {
                mainNotificationMessage = $"Ada {barangStokKritis} jenis barang dengan stok kritis.";
                labelNotification.ForeColor = Color.Red; // Warna bahaya
                labelCriticalStockWarning.Text = $"Perhatian! Ada {barangStokKritis} barang dengan stok di bawah batas aman.";
                labelCriticalStockWarning.Visible = true;
            }
            else
            {
                mainNotificationMessage = "Tidak ada notifikasi penting saat ini. Semua terkendali.";
                labelNotification.ForeColor = Color.DimGray;
            }

            labelNotification.Text = mainNotificationMessage;
        }


        // --- Event handlers untuk Aksi Cepat ---
        private void btnBuatPermintaanBaru_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Menu_Utama mainForm)
            {
                mainForm.ShowMdiChildForm(typeof(FormPermintaan));
            }
        }

        private void btnLihatPermintaanPending_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Menu_Utama mainForm)
            {
               mainForm.ShowMdiChildForm(typeof(FormLaporanAktivitas));
            }
        }

        private void btnLihatStokKritis_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Menu_Utama mainForm)
            {
                mainForm.ShowMdiChildForm(typeof(FormDataBarang));
                // Opsional: Jika FormDataBarang punya metode untuk memfilter
                // ((FormDataBarang)mainForm.GetMdiChild(typeof(FormDataBarang))).FilterByStokKritis();
            }
        }

        // Anda bisa menambahkan fitur refresh data dashboard
        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void betterRoundedPanel1_Click(object sender, EventArgs e)
        {

        }

        // Tambahkan metode public ini
        public void RefreshDashboardData()
        {
            LoadDashboardData();
        }
    }
}