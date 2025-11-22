namespace Aplikasi_Manajemen_Studio
{
    partial class FormLaporanAktivitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanAktivitas));
            tabControlLaporan = new TabControl();
            tabPagePeminjaman = new TabPage();
            dgvLaporanPeminjaman = new DataGridView();
            panel1 = new Panel();
            btnCetak_Pinjam = new Button();
            button2 = new Button();
            btnEkspor_Pinjam = new Button();
            btnResetFilter_Pinjam = new Button();
            rbSemua_Pinjam = new RadioButton();
            rbSiswa_Pinjam = new RadioButton();
            rbGuru_Pinjam = new RadioButton();
            btnReset_Pinjam = new Button();
            btnTampil_Pinjam = new Button();
            btnCari_Pinjam = new Button();
            txtPeminjam_Pinjam = new TextBox();
            cmbStatus_Pinjam = new ComboBox();
            dtpHingga_Pinjam = new DateTimePicker();
            label7 = new Label();
            dtpDari_Pinjam = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tabPagePermintaan = new TabPage();
            dgvLaporanPermintaan = new DataGridView();
            panel2 = new Panel();
            btnCetak_Minta = new Button();
            button1 = new Button();
            btnResetFilter_Minta = new Button();
            btnReset_Minta = new Button();
            btnEkspor_Minta = new Button();
            rbSemua_Minta = new RadioButton();
            rbSiswa_Minta = new RadioButton();
            rbGuru_Minta = new RadioButton();
            btnTampil_Minta = new Button();
            btnCari_Minta = new Button();
            txtPemohon_Minta = new TextBox();
            dtpHingga_Minta = new DateTimePicker();
            label8 = new Label();
            dtpDari_Minta = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            tabPagePembelian = new TabPage();
            dgvLaporanPembelian = new DataGridView();
            panel3 = new Panel();
            btnCetak_Beli = new Button();
            btnTutup = new Button();
            btnEkspor_Beli = new Button();
            btnReset_Beli = new Button();
            label22 = new Label();
            label23 = new Label();
            txtPemasok_Beli = new TextBox();
            btnTampil_Beli = new Button();
            cmbBarang_Beli = new ComboBox();
            dtpHingga_Beli = new DateTimePicker();
            label15 = new Label();
            dtpDari_Beli = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            tabControlLaporan.SuspendLayout();
            tabPagePeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPeminjaman).BeginInit();
            panel1.SuspendLayout();
            tabPagePermintaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPermintaan).BeginInit();
            panel2.SuspendLayout();
            tabPagePembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPembelian).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLaporan
            // 
            tabControlLaporan.Controls.Add(tabPagePeminjaman);
            tabControlLaporan.Controls.Add(tabPagePermintaan);
            tabControlLaporan.Controls.Add(tabPagePembelian);
            tabControlLaporan.Dock = DockStyle.Fill;
            tabControlLaporan.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlLaporan.Location = new Point(0, 0);
            tabControlLaporan.Name = "tabControlLaporan";
            tabControlLaporan.SelectedIndex = 0;
            tabControlLaporan.Size = new Size(1383, 778);
            tabControlLaporan.TabIndex = 0;
            // 
            // tabPagePeminjaman
            // 
            tabPagePeminjaman.BackColor = SystemColors.Control;
            tabPagePeminjaman.Controls.Add(dgvLaporanPeminjaman);
            tabPagePeminjaman.Controls.Add(panel1);
            tabPagePeminjaman.Cursor = Cursors.Hand;
            tabPagePeminjaman.ForeColor = Color.Black;
            tabPagePeminjaman.Location = new Point(4, 38);
            tabPagePeminjaman.Name = "tabPagePeminjaman";
            tabPagePeminjaman.Padding = new Padding(3);
            tabPagePeminjaman.Size = new Size(1375, 736);
            tabPagePeminjaman.TabIndex = 0;
            tabPagePeminjaman.Text = "Laporan Peminjaman";
            // 
            // dgvLaporanPeminjaman
            // 
            dgvLaporanPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporanPeminjaman.Dock = DockStyle.Fill;
            dgvLaporanPeminjaman.Location = new Point(3, 350);
            dgvLaporanPeminjaman.Name = "dgvLaporanPeminjaman";
            dgvLaporanPeminjaman.ReadOnly = true;
            dgvLaporanPeminjaman.Size = new Size(1369, 383);
            dgvLaporanPeminjaman.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(btnCetak_Pinjam);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEkspor_Pinjam);
            panel1.Controls.Add(btnResetFilter_Pinjam);
            panel1.Controls.Add(rbSemua_Pinjam);
            panel1.Controls.Add(rbSiswa_Pinjam);
            panel1.Controls.Add(rbGuru_Pinjam);
            panel1.Controls.Add(btnReset_Pinjam);
            panel1.Controls.Add(btnTampil_Pinjam);
            panel1.Controls.Add(btnCari_Pinjam);
            panel1.Controls.Add(txtPeminjam_Pinjam);
            panel1.Controls.Add(cmbStatus_Pinjam);
            panel1.Controls.Add(dtpHingga_Pinjam);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpDari_Pinjam);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 347);
            panel1.TabIndex = 12;
            // 
            // btnCetak_Pinjam
            // 
            btnCetak_Pinjam.BackColor = Color.Goldenrod;
            btnCetak_Pinjam.Cursor = Cursors.Hand;
            btnCetak_Pinjam.FlatStyle = FlatStyle.Popup;
            btnCetak_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetak_Pinjam.ForeColor = Color.WhiteSmoke;
            btnCetak_Pinjam.Location = new Point(1041, 161);
            btnCetak_Pinjam.Name = "btnCetak_Pinjam";
            btnCetak_Pinjam.Size = new Size(297, 43);
            btnCetak_Pinjam.TabIndex = 29;
            btnCetak_Pinjam.Text = " Cetak Laporan";
            btnCetak_Pinjam.UseVisualStyleBackColor = false;
            btnCetak_Pinjam.Click += btnCetak_Pinjam_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1041, 264);
            button2.Name = "button2";
            button2.Size = new Size(297, 43);
            button2.TabIndex = 28;
            button2.Text = "Tutup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnTutup_Click;
            // 
            // btnEkspor_Pinjam
            // 
            btnEkspor_Pinjam.BackColor = Color.DarkOrange;
            btnEkspor_Pinjam.Cursor = Cursors.Hand;
            btnEkspor_Pinjam.FlatStyle = FlatStyle.Popup;
            btnEkspor_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkspor_Pinjam.ForeColor = Color.White;
            btnEkspor_Pinjam.Location = new Point(720, 264);
            btnEkspor_Pinjam.Name = "btnEkspor_Pinjam";
            btnEkspor_Pinjam.Size = new Size(275, 43);
            btnEkspor_Pinjam.TabIndex = 21;
            btnEkspor_Pinjam.Text = "Ekspor CSV";
            btnEkspor_Pinjam.UseVisualStyleBackColor = false;
            btnEkspor_Pinjam.Click += btnEkspor_Pinjam_Click;
            // 
            // btnResetFilter_Pinjam
            // 
            btnResetFilter_Pinjam.BackColor = Color.Firebrick;
            btnResetFilter_Pinjam.Cursor = Cursors.Hand;
            btnResetFilter_Pinjam.FlatStyle = FlatStyle.Popup;
            btnResetFilter_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetFilter_Pinjam.ForeColor = Color.White;
            btnResetFilter_Pinjam.Location = new Point(791, 177);
            btnResetFilter_Pinjam.Name = "btnResetFilter_Pinjam";
            btnResetFilter_Pinjam.Size = new Size(204, 24);
            btnResetFilter_Pinjam.TabIndex = 20;
            btnResetFilter_Pinjam.Text = "Reset Peminjam";
            btnResetFilter_Pinjam.UseVisualStyleBackColor = false;
            btnResetFilter_Pinjam.Click += btnReset_Pinjam_Click;
            // 
            // rbSemua_Pinjam
            // 
            rbSemua_Pinjam.AutoSize = true;
            rbSemua_Pinjam.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSemua_Pinjam.Location = new Point(239, 121);
            rbSemua_Pinjam.Name = "rbSemua_Pinjam";
            rbSemua_Pinjam.Size = new Size(102, 27);
            rbSemua_Pinjam.TabIndex = 19;
            rbSemua_Pinjam.TabStop = true;
            rbSemua_Pinjam.Text = "Semua";
            rbSemua_Pinjam.UseVisualStyleBackColor = true;
            rbSemua_Pinjam.CheckedChanged += rbPeminjam_Pinjam_CheckedChanged;
            // 
            // rbSiswa_Pinjam
            // 
            rbSiswa_Pinjam.AutoSize = true;
            rbSiswa_Pinjam.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSiswa_Pinjam.Location = new Point(457, 121);
            rbSiswa_Pinjam.Name = "rbSiswa_Pinjam";
            rbSiswa_Pinjam.Size = new Size(92, 27);
            rbSiswa_Pinjam.TabIndex = 18;
            rbSiswa_Pinjam.TabStop = true;
            rbSiswa_Pinjam.Text = "Siswa";
            rbSiswa_Pinjam.UseVisualStyleBackColor = true;
            rbSiswa_Pinjam.CheckedChanged += rbPeminjam_Pinjam_CheckedChanged;
            // 
            // rbGuru_Pinjam
            // 
            rbGuru_Pinjam.AutoSize = true;
            rbGuru_Pinjam.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbGuru_Pinjam.Location = new Point(356, 121);
            rbGuru_Pinjam.Name = "rbGuru_Pinjam";
            rbGuru_Pinjam.Size = new Size(80, 27);
            rbGuru_Pinjam.TabIndex = 17;
            rbGuru_Pinjam.TabStop = true;
            rbGuru_Pinjam.Text = "Guru";
            rbGuru_Pinjam.UseVisualStyleBackColor = true;
            rbGuru_Pinjam.CheckedChanged += rbPeminjam_Pinjam_CheckedChanged;
            // 
            // btnReset_Pinjam
            // 
            btnReset_Pinjam.BackColor = Color.Firebrick;
            btnReset_Pinjam.Cursor = Cursors.Hand;
            btnReset_Pinjam.FlatStyle = FlatStyle.Popup;
            btnReset_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset_Pinjam.ForeColor = Color.White;
            btnReset_Pinjam.Location = new Point(377, 264);
            btnReset_Pinjam.Name = "btnReset_Pinjam";
            btnReset_Pinjam.Size = new Size(275, 43);
            btnReset_Pinjam.TabIndex = 16;
            btnReset_Pinjam.Text = "Reset Filter";
            btnReset_Pinjam.UseVisualStyleBackColor = false;
            btnReset_Pinjam.Click += btnReset_Pinjam_Click;
            // 
            // btnTampil_Pinjam
            // 
            btnTampil_Pinjam.BackColor = Color.OliveDrab;
            btnTampil_Pinjam.Cursor = Cursors.Hand;
            btnTampil_Pinjam.FlatStyle = FlatStyle.Popup;
            btnTampil_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTampil_Pinjam.ForeColor = Color.White;
            btnTampil_Pinjam.Location = new Point(28, 264);
            btnTampil_Pinjam.Name = "btnTampil_Pinjam";
            btnTampil_Pinjam.Size = new Size(275, 43);
            btnTampil_Pinjam.TabIndex = 15;
            btnTampil_Pinjam.Text = "Tampilkan Laporan";
            btnTampil_Pinjam.UseVisualStyleBackColor = false;
            btnTampil_Pinjam.Click += btnTampil_Pinjam_Click;
            // 
            // btnCari_Pinjam
            // 
            btnCari_Pinjam.BackColor = Color.Firebrick;
            btnCari_Pinjam.Cursor = Cursors.Hand;
            btnCari_Pinjam.FlatStyle = FlatStyle.Popup;
            btnCari_Pinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari_Pinjam.ForeColor = Color.White;
            btnCari_Pinjam.Location = new Point(564, 177);
            btnCari_Pinjam.Name = "btnCari_Pinjam";
            btnCari_Pinjam.Size = new Size(204, 24);
            btnCari_Pinjam.TabIndex = 14;
            btnCari_Pinjam.Text = "Cari Peminjam";
            btnCari_Pinjam.UseVisualStyleBackColor = false;
            btnCari_Pinjam.Click += btnCari_Pinjam_Click;
            // 
            // txtPeminjam_Pinjam
            // 
            txtPeminjam_Pinjam.Location = new Point(239, 177);
            txtPeminjam_Pinjam.Name = "txtPeminjam_Pinjam";
            txtPeminjam_Pinjam.ReadOnly = true;
            txtPeminjam_Pinjam.Size = new Size(310, 27);
            txtPeminjam_Pinjam.TabIndex = 13;
            // 
            // cmbStatus_Pinjam
            // 
            cmbStatus_Pinjam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus_Pinjam.FormattingEnabled = true;
            cmbStatus_Pinjam.Items.AddRange(new object[] { "Semua", "Dipinjam", "Sudah Kembali" });
            cmbStatus_Pinjam.Location = new Point(239, 74);
            cmbStatus_Pinjam.Name = "cmbStatus_Pinjam";
            cmbStatus_Pinjam.Size = new Size(310, 26);
            cmbStatus_Pinjam.TabIndex = 12;
            // 
            // dtpHingga_Pinjam
            // 
            dtpHingga_Pinjam.Location = new Point(604, 27);
            dtpHingga_Pinjam.Name = "dtpHingga_Pinjam";
            dtpHingga_Pinjam.Size = new Size(310, 27);
            dtpHingga_Pinjam.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 33);
            label7.Name = "label7";
            label7.Size = new Size(43, 18);
            label7.TabIndex = 10;
            label7.Text = "S/D";
            // 
            // dtpDari_Pinjam
            // 
            dtpDari_Pinjam.Location = new Point(239, 27);
            dtpDari_Pinjam.Name = "dtpDari_Pinjam";
            dtpDari_Pinjam.Size = new Size(310, 27);
            dtpDari_Pinjam.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 124);
            label5.Name = "label5";
            label5.Size = new Size(14, 18);
            label5.TabIndex = 8;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 124);
            label6.Name = "label6";
            label6.Size = new Size(103, 18);
            label6.TabIndex = 7;
            label6.Text = "PEMINJAM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 77);
            label4.Name = "label4";
            label4.Size = new Size(14, 18);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 27);
            label2.Name = "label2";
            label2.Size = new Size(14, 18);
            label2.TabIndex = 5;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 77);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 4;
            label1.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 27);
            label3.Name = "label3";
            label3.Size = new Size(185, 18);
            label3.TabIndex = 3;
            label3.Text = "RENTANG TANGGAL";
            // 
            // tabPagePermintaan
            // 
            tabPagePermintaan.BackColor = Color.LightGray;
            tabPagePermintaan.Controls.Add(dgvLaporanPermintaan);
            tabPagePermintaan.Controls.Add(panel2);
            tabPagePermintaan.Cursor = Cursors.Hand;
            tabPagePermintaan.Location = new Point(4, 38);
            tabPagePermintaan.Name = "tabPagePermintaan";
            tabPagePermintaan.Padding = new Padding(3);
            tabPagePermintaan.Size = new Size(1375, 736);
            tabPagePermintaan.TabIndex = 1;
            tabPagePermintaan.Text = "Laporan Permintaan";
            tabPagePermintaan.Click += tabPage2_Click;
            // 
            // dgvLaporanPermintaan
            // 
            dgvLaporanPermintaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporanPermintaan.Dock = DockStyle.Fill;
            dgvLaporanPermintaan.Location = new Point(3, 304);
            dgvLaporanPermintaan.Name = "dgvLaporanPermintaan";
            dgvLaporanPermintaan.ReadOnly = true;
            dgvLaporanPermintaan.Size = new Size(1369, 429);
            dgvLaporanPermintaan.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(btnCetak_Minta);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnResetFilter_Minta);
            panel2.Controls.Add(btnReset_Minta);
            panel2.Controls.Add(btnEkspor_Minta);
            panel2.Controls.Add(rbSemua_Minta);
            panel2.Controls.Add(rbSiswa_Minta);
            panel2.Controls.Add(rbGuru_Minta);
            panel2.Controls.Add(btnTampil_Minta);
            panel2.Controls.Add(btnCari_Minta);
            panel2.Controls.Add(txtPemohon_Minta);
            panel2.Controls.Add(dtpHingga_Minta);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dtpDari_Minta);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label14);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1369, 301);
            panel2.TabIndex = 13;
            // 
            // btnCetak_Minta
            // 
            btnCetak_Minta.BackColor = Color.Goldenrod;
            btnCetak_Minta.Cursor = Cursors.Hand;
            btnCetak_Minta.FlatStyle = FlatStyle.Popup;
            btnCetak_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetak_Minta.ForeColor = Color.WhiteSmoke;
            btnCetak_Minta.Location = new Point(1055, 118);
            btnCetak_Minta.Name = "btnCetak_Minta";
            btnCetak_Minta.Size = new Size(261, 43);
            btnCetak_Minta.TabIndex = 30;
            btnCetak_Minta.Text = " Cetak Laporan";
            btnCetak_Minta.UseVisualStyleBackColor = false;
            btnCetak_Minta.Click += btnCetak_Minta_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1055, 216);
            button1.Name = "button1";
            button1.Size = new Size(270, 43);
            button1.TabIndex = 28;
            button1.Text = "Tutup";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnTutup_Click;
            // 
            // btnResetFilter_Minta
            // 
            btnResetFilter_Minta.BackColor = Color.Firebrick;
            btnResetFilter_Minta.Cursor = Cursors.Hand;
            btnResetFilter_Minta.FlatStyle = FlatStyle.Popup;
            btnResetFilter_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetFilter_Minta.ForeColor = Color.White;
            btnResetFilter_Minta.Location = new Point(793, 134);
            btnResetFilter_Minta.Name = "btnResetFilter_Minta";
            btnResetFilter_Minta.Size = new Size(204, 24);
            btnResetFilter_Minta.TabIndex = 23;
            btnResetFilter_Minta.Text = "Reset Peminjam";
            btnResetFilter_Minta.UseVisualStyleBackColor = false;
            btnResetFilter_Minta.Click += btnReset_Minta_Click;
            // 
            // btnReset_Minta
            // 
            btnReset_Minta.BackColor = Color.Firebrick;
            btnReset_Minta.Cursor = Cursors.Hand;
            btnReset_Minta.FlatStyle = FlatStyle.Popup;
            btnReset_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset_Minta.ForeColor = Color.White;
            btnReset_Minta.Location = new Point(375, 216);
            btnReset_Minta.Name = "btnReset_Minta";
            btnReset_Minta.Size = new Size(275, 43);
            btnReset_Minta.TabIndex = 22;
            btnReset_Minta.Text = "Reset Filter";
            btnReset_Minta.UseVisualStyleBackColor = false;
            btnReset_Minta.Click += btnReset_Minta_Click;
            // 
            // btnEkspor_Minta
            // 
            btnEkspor_Minta.BackColor = Color.DarkOrange;
            btnEkspor_Minta.Cursor = Cursors.Hand;
            btnEkspor_Minta.FlatStyle = FlatStyle.Popup;
            btnEkspor_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkspor_Minta.ForeColor = Color.White;
            btnEkspor_Minta.Location = new Point(720, 216);
            btnEkspor_Minta.Name = "btnEkspor_Minta";
            btnEkspor_Minta.Size = new Size(275, 43);
            btnEkspor_Minta.TabIndex = 21;
            btnEkspor_Minta.Text = "Ekspor CSV";
            btnEkspor_Minta.UseVisualStyleBackColor = false;
            btnEkspor_Minta.Click += btnEkspor_Minta_Click;
            // 
            // rbSemua_Minta
            // 
            rbSemua_Minta.AutoSize = true;
            rbSemua_Minta.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSemua_Minta.Location = new Point(241, 78);
            rbSemua_Minta.Name = "rbSemua_Minta";
            rbSemua_Minta.Size = new Size(102, 27);
            rbSemua_Minta.TabIndex = 19;
            rbSemua_Minta.TabStop = true;
            rbSemua_Minta.Text = "Semua";
            rbSemua_Minta.UseVisualStyleBackColor = true;
            rbSemua_Minta.Click += rbPemohon_Minta_CheckedChanged;
            // 
            // rbSiswa_Minta
            // 
            rbSiswa_Minta.AutoSize = true;
            rbSiswa_Minta.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSiswa_Minta.Location = new Point(459, 78);
            rbSiswa_Minta.Name = "rbSiswa_Minta";
            rbSiswa_Minta.Size = new Size(92, 27);
            rbSiswa_Minta.TabIndex = 18;
            rbSiswa_Minta.TabStop = true;
            rbSiswa_Minta.Text = "Siswa";
            rbSiswa_Minta.UseVisualStyleBackColor = true;
            rbSiswa_Minta.Click += rbPemohon_Minta_CheckedChanged;
            // 
            // rbGuru_Minta
            // 
            rbGuru_Minta.AutoSize = true;
            rbGuru_Minta.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbGuru_Minta.Location = new Point(358, 78);
            rbGuru_Minta.Name = "rbGuru_Minta";
            rbGuru_Minta.Size = new Size(80, 27);
            rbGuru_Minta.TabIndex = 17;
            rbGuru_Minta.TabStop = true;
            rbGuru_Minta.Text = "Guru";
            rbGuru_Minta.UseVisualStyleBackColor = true;
            rbGuru_Minta.Click += rbPemohon_Minta_CheckedChanged;
            // 
            // btnTampil_Minta
            // 
            btnTampil_Minta.BackColor = Color.OliveDrab;
            btnTampil_Minta.Cursor = Cursors.Hand;
            btnTampil_Minta.FlatStyle = FlatStyle.Popup;
            btnTampil_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTampil_Minta.ForeColor = Color.White;
            btnTampil_Minta.Location = new Point(28, 216);
            btnTampil_Minta.Name = "btnTampil_Minta";
            btnTampil_Minta.Size = new Size(275, 43);
            btnTampil_Minta.TabIndex = 15;
            btnTampil_Minta.Text = "Tampilkan Laporan";
            btnTampil_Minta.UseVisualStyleBackColor = false;
            btnTampil_Minta.Click += btnTampil_Minta_Click;
            // 
            // btnCari_Minta
            // 
            btnCari_Minta.BackColor = Color.Firebrick;
            btnCari_Minta.Cursor = Cursors.Hand;
            btnCari_Minta.FlatStyle = FlatStyle.Popup;
            btnCari_Minta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari_Minta.ForeColor = Color.White;
            btnCari_Minta.Location = new Point(566, 134);
            btnCari_Minta.Name = "btnCari_Minta";
            btnCari_Minta.Size = new Size(204, 24);
            btnCari_Minta.TabIndex = 14;
            btnCari_Minta.Text = "Cari Peminta";
            btnCari_Minta.UseVisualStyleBackColor = false;
            btnCari_Minta.Click += btnCari_Minta_Click;
            // 
            // txtPemohon_Minta
            // 
            txtPemohon_Minta.Location = new Point(241, 134);
            txtPemohon_Minta.Name = "txtPemohon_Minta";
            txtPemohon_Minta.ReadOnly = true;
            txtPemohon_Minta.Size = new Size(310, 27);
            txtPemohon_Minta.TabIndex = 13;
            // 
            // dtpHingga_Minta
            // 
            dtpHingga_Minta.Location = new Point(604, 27);
            dtpHingga_Minta.Name = "dtpHingga_Minta";
            dtpHingga_Minta.Size = new Size(310, 27);
            dtpHingga_Minta.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 33);
            label8.Name = "label8";
            label8.Size = new Size(43, 18);
            label8.TabIndex = 10;
            label8.Text = "S/D";
            // 
            // dtpDari_Minta
            // 
            dtpDari_Minta.Location = new Point(239, 27);
            dtpDari_Minta.Name = "dtpDari_Minta";
            dtpDari_Minta.Size = new Size(310, 27);
            dtpDari_Minta.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(221, 81);
            label9.Name = "label9";
            label9.Size = new Size(14, 18);
            label9.TabIndex = 8;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 81);
            label10.Name = "label10";
            label10.Size = new Size(91, 18);
            label10.TabIndex = 7;
            label10.Text = "PEMINTA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(219, 27);
            label12.Name = "label12";
            label12.Size = new Size(14, 18);
            label12.TabIndex = 5;
            label12.Text = ":";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 27);
            label14.Name = "label14";
            label14.Size = new Size(185, 18);
            label14.TabIndex = 3;
            label14.Text = "RENTANG TANGGAL";
            // 
            // tabPagePembelian
            // 
            tabPagePembelian.BackColor = Color.LightGray;
            tabPagePembelian.Controls.Add(dgvLaporanPembelian);
            tabPagePembelian.Controls.Add(panel3);
            tabPagePembelian.Cursor = Cursors.Hand;
            tabPagePembelian.Location = new Point(4, 38);
            tabPagePembelian.Name = "tabPagePembelian";
            tabPagePembelian.Size = new Size(1375, 736);
            tabPagePembelian.TabIndex = 2;
            tabPagePembelian.Text = "Laporan Pembelian";
            // 
            // dgvLaporanPembelian
            // 
            dgvLaporanPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporanPembelian.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLaporanPembelian.BorderStyle = BorderStyle.None;
            dgvLaporanPembelian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporanPembelian.Dock = DockStyle.Fill;
            dgvLaporanPembelian.Location = new Point(0, 280);
            dgvLaporanPembelian.Name = "dgvLaporanPembelian";
            dgvLaporanPembelian.ReadOnly = true;
            dgvLaporanPembelian.Size = new Size(1375, 456);
            dgvLaporanPembelian.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(btnCetak_Beli);
            panel3.Controls.Add(btnTutup);
            panel3.Controls.Add(btnEkspor_Beli);
            panel3.Controls.Add(btnReset_Beli);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(txtPemasok_Beli);
            panel3.Controls.Add(btnTampil_Beli);
            panel3.Controls.Add(cmbBarang_Beli);
            panel3.Controls.Add(dtpHingga_Beli);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(dtpDari_Beli);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1375, 280);
            panel3.TabIndex = 14;
            // 
            // btnCetak_Beli
            // 
            btnCetak_Beli.BackColor = Color.Goldenrod;
            btnCetak_Beli.Cursor = Cursors.Hand;
            btnCetak_Beli.FlatStyle = FlatStyle.Popup;
            btnCetak_Beli.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetak_Beli.ForeColor = Color.WhiteSmoke;
            btnCetak_Beli.Location = new Point(1019, 114);
            btnCetak_Beli.Name = "btnCetak_Beli";
            btnCetak_Beli.Size = new Size(297, 43);
            btnCetak_Beli.TabIndex = 30;
            btnCetak_Beli.Text = " Cetak Laporan";
            btnCetak_Beli.UseVisualStyleBackColor = false;
            btnCetak_Beli.Click += btnCetak_Beli_Click;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Firebrick;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(1019, 199);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(297, 43);
            btnTutup.TabIndex = 27;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnEkspor_Beli
            // 
            btnEkspor_Beli.BackColor = Color.DarkOrange;
            btnEkspor_Beli.Cursor = Cursors.Hand;
            btnEkspor_Beli.FlatStyle = FlatStyle.Popup;
            btnEkspor_Beli.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkspor_Beli.ForeColor = Color.White;
            btnEkspor_Beli.Location = new Point(681, 199);
            btnEkspor_Beli.Name = "btnEkspor_Beli";
            btnEkspor_Beli.Size = new Size(275, 43);
            btnEkspor_Beli.TabIndex = 26;
            btnEkspor_Beli.Text = "Ekspor CSV";
            btnEkspor_Beli.UseVisualStyleBackColor = false;
            btnEkspor_Beli.Click += btnEkspor_Beli_Click;
            // 
            // btnReset_Beli
            // 
            btnReset_Beli.BackColor = Color.Firebrick;
            btnReset_Beli.Cursor = Cursors.Hand;
            btnReset_Beli.FlatStyle = FlatStyle.Popup;
            btnReset_Beli.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset_Beli.ForeColor = Color.White;
            btnReset_Beli.Location = new Point(345, 199);
            btnReset_Beli.Name = "btnReset_Beli";
            btnReset_Beli.Size = new Size(275, 43);
            btnReset_Beli.TabIndex = 25;
            btnReset_Beli.Text = "Reset Filter";
            btnReset_Beli.UseVisualStyleBackColor = false;
            btnReset_Beli.Click += btnReset_Beli_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(219, 81);
            label22.Name = "label22";
            label22.Size = new Size(14, 18);
            label22.TabIndex = 24;
            label22.Text = ":";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(29, 81);
            label23.Name = "label23";
            label23.Size = new Size(95, 18);
            label23.TabIndex = 23;
            label23.Text = "PEMASOK";
            // 
            // txtPemasok_Beli
            // 
            txtPemasok_Beli.Location = new Point(239, 78);
            txtPemasok_Beli.Name = "txtPemasok_Beli";
            txtPemasok_Beli.Size = new Size(310, 27);
            txtPemasok_Beli.TabIndex = 22;
            // 
            // btnTampil_Beli
            // 
            btnTampil_Beli.BackColor = Color.OliveDrab;
            btnTampil_Beli.Cursor = Cursors.Hand;
            btnTampil_Beli.FlatStyle = FlatStyle.Popup;
            btnTampil_Beli.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTampil_Beli.ForeColor = Color.White;
            btnTampil_Beli.Location = new Point(16, 199);
            btnTampil_Beli.Name = "btnTampil_Beli";
            btnTampil_Beli.Size = new Size(275, 43);
            btnTampil_Beli.TabIndex = 15;
            btnTampil_Beli.Text = "Tampilkan Laporan";
            btnTampil_Beli.UseVisualStyleBackColor = false;
            btnTampil_Beli.Click += btnTampil_Beli_Click;
            // 
            // cmbBarang_Beli
            // 
            cmbBarang_Beli.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarang_Beli.FormattingEnabled = true;
            cmbBarang_Beli.Items.AddRange(new object[] { "Semua", "Dipinjam", "Sudah Kembali" });
            cmbBarang_Beli.Location = new Point(239, 123);
            cmbBarang_Beli.Name = "cmbBarang_Beli";
            cmbBarang_Beli.Size = new Size(310, 26);
            cmbBarang_Beli.TabIndex = 12;
            // 
            // dtpHingga_Beli
            // 
            dtpHingga_Beli.Location = new Point(604, 27);
            dtpHingga_Beli.Name = "dtpHingga_Beli";
            dtpHingga_Beli.Size = new Size(310, 27);
            dtpHingga_Beli.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(555, 33);
            label15.Name = "label15";
            label15.Size = new Size(43, 18);
            label15.TabIndex = 10;
            label15.Text = "S/D";
            // 
            // dtpDari_Beli
            // 
            dtpDari_Beli.Location = new Point(239, 27);
            dtpDari_Beli.Name = "dtpDari_Beli";
            dtpDari_Beli.Size = new Size(310, 27);
            dtpDari_Beli.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(219, 126);
            label18.Name = "label18";
            label18.Size = new Size(14, 18);
            label18.TabIndex = 6;
            label18.Text = ":";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(219, 27);
            label19.Name = "label19";
            label19.Size = new Size(14, 18);
            label19.TabIndex = 5;
            label19.Text = ":";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(28, 126);
            label20.Name = "label20";
            label20.Size = new Size(83, 18);
            label20.TabIndex = 4;
            label20.Text = "BARANG";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(28, 27);
            label21.Name = "label21";
            label21.Size = new Size(185, 18);
            label21.TabIndex = 3;
            label21.Text = "RENTANG TANGGAL";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormLaporanAktivitas
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 778);
            Controls.Add(tabControlLaporan);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLaporanAktivitas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLaporanAktivitas";
            Load += FormLaporanAktivitas_Load;
            tabControlLaporan.ResumeLayout(false);
            tabPagePeminjaman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPeminjaman).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPagePermintaan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPermintaan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPagePembelian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporanPembelian).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlLaporan;
        private TabPage tabPagePeminjaman;
        private TabPage tabPagePermintaan;
        private TabPage tabPagePembelian;
        private DataGridView dgvLaporanPermintaan;
        private Panel panel2;
        private Button btnEkspor_Minta;
        private Button btnResetPemintaFilter;
        private RadioButton rbSemua_Minta;
        private RadioButton rbSiswa_Minta;
        private RadioButton rbGuru_Minta;
        private Button btnResetFIlterPermintaan;
        private Button btnTampil_Minta;
        private Button btnCari_Minta;
        private TextBox txtPemohon_Minta;
        private DateTimePicker dtpHingga_Minta;
        private Label label8;
        private DateTimePicker dtpDari_Minta;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label14;
        private Panel panel1;
        private Button btnEkspor_Pinjam;
        private Button btnResetFilter_Pinjam;
        private RadioButton rbSemua_Pinjam;
        private RadioButton rbSiswa_Pinjam;
        private RadioButton rbGuru_Pinjam;
        private Button btnReset_Pinjam;
        private Button btnTampil_Pinjam;
        private Button btnCari_Pinjam;
        private TextBox txtPeminjam_Pinjam;
        private ComboBox cmbStatus_Pinjam;
        private DateTimePicker dtpHingga_Pinjam;
        private Label label7;
        private DateTimePicker dtpDari_Pinjam;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnTutup;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button3;
        private Button button5;
        private TextBox textBox1;
        private Label label16;
        private Label label17;
        private DataGridView dgvLaporanPembelian;
        private Button btnResetFilter_Minta;
        private Button btnReset_Minta;
        private Panel panel3;
        private Button btnEkspor_Beli;
        private Button btnReset_Beli;
        private Label label22;
        private Label label23;
        private TextBox txtPemasok_Beli;
        private Button btnTampil_Beli;
        private ComboBox cmbBarang_Beli;
        private DateTimePicker dtpHingga_Beli;
        private Label label15;
        private DateTimePicker dtpDari_Beli;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button button1;
        private DataGridView dgvLaporanPeminjaman;
        private Button btnCetak_Pinjam;
        private Button btnCetak_Minta;
        private Button btnCetak_Beli;
        private PrintPreviewDialog printPreviewDialog1;
    }
}