namespace Aplikasi_Manajemen_Studio
{
    partial class Menu_Utama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            panelTop = new Panel();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btn_Pengembalian = new Button();
            pictureBox3 = new PictureBox();
            btn_Peminjaman = new Button();
            pictureBox2 = new PictureBox();
            titik1 = new Label();
            titik3 = new Label();
            lblIDPetugas = new Label();
            titik2 = new Label();
            lblJabatan = new Label();
            lblNamaPetugas = new Label();
            btnLogout = new Button();
            btnLogin = new Button();
            btn_Pembelian = new Button();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            btn_Permintaan = new Button();
            pictureBox12 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox13 = new PictureBox();
            btnResetData = new Button();
            pictureBox9 = new PictureBox();
            labelIDUser = new Label();
            pictureBox14 = new PictureBox();
            pictureBox19 = new PictureBox();
            label5 = new Label();
            btnData_Barang = new Button();
            label6 = new Label();
            btnRestore = new Button();
            btnTransaksi = new Button();
            pctUser = new PictureBox();
            btnData_Petugas = new Button();
            pictureBox20 = new PictureBox();
            pictureBox16 = new PictureBox();
            labelNamaUser = new Label();
            btnData_Kelas = new Button();
            btnBackup = new Button();
            labelJabatanUser = new Label();
            btnData_Guru = new Button();
            pictureBox18 = new PictureBox();
            panel4 = new Panel();
            btnData_Siswa = new Button();
            label11 = new Label();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel5 = new Panel();
            statusStrip1 = new StatusStrip();
            statusStripLabelStatus = new ToolStripStatusLabel();
            statusStripLabelDateTime = new ToolStripStatusLabel();
            waktu = new System.Windows.Forms.Timer(components);
            btnLaporKerusakan = new Button();
            pictureBox4 = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            panel5.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnExit);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1296, 50);
            panelTop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 15);
            label1.Name = "label1";
            label1.Size = new Size(312, 18);
            label1.TabIndex = 0;
            label1.Text = "AMS - Aplikasi Manajemen SarPras";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1229, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.SMK_N_8_JAKARTA;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(19, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnLaporKerusakan);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btn_Pengembalian);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btn_Peminjaman);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(titik1);
            panel3.Controls.Add(titik3);
            panel3.Controls.Add(lblIDPetugas);
            panel3.Controls.Add(titik2);
            panel3.Controls.Add(lblJabatan);
            panel3.Controls.Add(lblNamaPetugas);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(btn_Pembelian);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(btn_Permintaan);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(pictureBox21);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(btnResetData);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(labelIDUser);
            panel3.Controls.Add(pictureBox14);
            panel3.Controls.Add(pictureBox19);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnData_Barang);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnRestore);
            panel3.Controls.Add(btnTransaksi);
            panel3.Controls.Add(pctUser);
            panel3.Controls.Add(btnData_Petugas);
            panel3.Controls.Add(pictureBox20);
            panel3.Controls.Add(pictureBox16);
            panel3.Controls.Add(labelNamaUser);
            panel3.Controls.Add(btnData_Kelas);
            panel3.Controls.Add(btnBackup);
            panel3.Controls.Add(labelJabatanUser);
            panel3.Controls.Add(btnData_Guru);
            panel3.Controls.Add(pictureBox18);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnData_Siswa);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 981);
            panel3.TabIndex = 22;
            // 
            // btn_Pengembalian
            // 
            btn_Pengembalian.Anchor = AnchorStyles.Top;
            btn_Pengembalian.BackColor = Color.Gainsboro;
            btn_Pengembalian.Cursor = Cursors.Hand;
            btn_Pengembalian.Enabled = false;
            btn_Pengembalian.FlatStyle = FlatStyle.Popup;
            btn_Pengembalian.Location = new Point(65, 616);
            btn_Pengembalian.Name = "btn_Pengembalian";
            btn_Pengembalian.Size = new Size(159, 28);
            btn_Pengembalian.TabIndex = 45;
            btn_Pengembalian.Text = "PENGEMBALIAN";
            btn_Pengembalian.UseVisualStyleBackColor = false;
            btn_Pengembalian.Click += btn_Pengembalian_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackgroundImage = Properties.Resources.pengembalian;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(31, 616);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // btn_Peminjaman
            // 
            btn_Peminjaman.Anchor = AnchorStyles.Top;
            btn_Peminjaman.BackColor = Color.Gainsboro;
            btn_Peminjaman.Cursor = Cursors.Hand;
            btn_Peminjaman.Enabled = false;
            btn_Peminjaman.FlatStyle = FlatStyle.Popup;
            btn_Peminjaman.Location = new Point(64, 582);
            btn_Peminjaman.Name = "btn_Peminjaman";
            btn_Peminjaman.Size = new Size(159, 28);
            btn_Peminjaman.TabIndex = 43;
            btn_Peminjaman.Text = "PEMINJAMAN";
            btn_Peminjaman.UseVisualStyleBackColor = false;
            btn_Peminjaman.Click += btn_Peminjaman_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackgroundImage = Properties.Resources.peminjaman;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(31, 582);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // titik1
            // 
            titik1.AutoSize = true;
            titik1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titik1.Location = new Point(136, 190);
            titik1.Name = "titik1";
            titik1.Size = new Size(14, 18);
            titik1.TabIndex = 42;
            titik1.Text = ":";
            titik1.Visible = false;
            // 
            // titik3
            // 
            titik3.AutoSize = true;
            titik3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titik3.Location = new Point(136, 247);
            titik3.Name = "titik3";
            titik3.Size = new Size(14, 18);
            titik3.TabIndex = 41;
            titik3.Text = ":";
            titik3.Visible = false;
            // 
            // lblIDPetugas
            // 
            lblIDPetugas.AutoSize = true;
            lblIDPetugas.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDPetugas.Location = new Point(3, 247);
            lblIDPetugas.Name = "lblIDPetugas";
            lblIDPetugas.Size = new Size(106, 18);
            lblIDPetugas.TabIndex = 40;
            lblIDPetugas.Text = "ID Petugas";
            lblIDPetugas.Visible = false;
            // 
            // titik2
            // 
            titik2.AutoSize = true;
            titik2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titik2.Location = new Point(136, 219);
            titik2.Name = "titik2";
            titik2.Size = new Size(14, 18);
            titik2.TabIndex = 39;
            titik2.Text = ":";
            titik2.Visible = false;
            // 
            // lblJabatan
            // 
            lblJabatan.AutoSize = true;
            lblJabatan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJabatan.Location = new Point(3, 219);
            lblJabatan.Name = "lblJabatan";
            lblJabatan.Size = new Size(79, 18);
            lblJabatan.TabIndex = 38;
            lblJabatan.Text = "Jabatan";
            lblJabatan.Visible = false;
            // 
            // lblNamaPetugas
            // 
            lblNamaPetugas.AutoSize = true;
            lblNamaPetugas.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaPetugas.Location = new Point(3, 190);
            lblNamaPetugas.Name = "lblNamaPetugas";
            lblNamaPetugas.Size = new Size(136, 18);
            lblNamaPetugas.TabIndex = 37;
            lblNamaPetugas.Text = "Nama Petugas";
            lblNamaPetugas.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top;
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Location = new Point(64, 830);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(159, 28);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(64, 830);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 28);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btn_Pembelian
            // 
            btn_Pembelian.Anchor = AnchorStyles.Top;
            btn_Pembelian.BackColor = Color.Gainsboro;
            btn_Pembelian.Cursor = Cursors.Hand;
            btn_Pembelian.Enabled = false;
            btn_Pembelian.FlatStyle = FlatStyle.Popup;
            btn_Pembelian.Location = new Point(64, 650);
            btn_Pembelian.Name = "btn_Pembelian";
            btn_Pembelian.Size = new Size(159, 28);
            btn_Pembelian.TabIndex = 7;
            btn_Pembelian.Text = "PEMBELIAN";
            btn_Pembelian.UseVisualStyleBackColor = false;
            btn_Pembelian.Click += btn_Pembelian_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top;
            pictureBox11.BackgroundImage = Properties.Resources.school;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(31, 435);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 28);
            pictureBox11.TabIndex = 15;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top;
            pictureBox10.BackgroundImage = Properties.Resources.police_emoji;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(31, 469);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(28, 28);
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            // 
            // btn_Permintaan
            // 
            btn_Permintaan.Anchor = AnchorStyles.Top;
            btn_Permintaan.BackColor = Color.Gainsboro;
            btn_Permintaan.Cursor = Cursors.Hand;
            btn_Permintaan.Enabled = false;
            btn_Permintaan.FlatStyle = FlatStyle.Popup;
            btn_Permintaan.Location = new Point(65, 548);
            btn_Permintaan.Name = "btn_Permintaan";
            btn_Permintaan.Size = new Size(159, 28);
            btn_Permintaan.TabIndex = 6;
            btn_Permintaan.Text = "PERMINTAAN";
            btn_Permintaan.UseVisualStyleBackColor = false;
            btn_Permintaan.Click += btn_Permintaan_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.Top;
            pictureBox12.BackgroundImage = Properties.Resources.man_teacher;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(32, 401);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(28, 28);
            pictureBox12.TabIndex = 14;
            pictureBox12.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Anchor = AnchorStyles.Top;
            pictureBox21.BackgroundImage = Properties.Resources.reset;
            pictureBox21.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox21.Location = new Point(29, 932);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(28, 28);
            pictureBox21.TabIndex = 36;
            pictureBox21.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top;
            pictureBox8.BackgroundImage = Properties.Resources.dwn;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(31, 548);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(28, 28);
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.Top;
            pictureBox13.BackgroundImage = Properties.Resources.graduatin_cap_emoji;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Location = new Point(31, 367);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 28);
            pictureBox13.TabIndex = 13;
            pictureBox13.TabStop = false;
            // 
            // btnResetData
            // 
            btnResetData.Anchor = AnchorStyles.Top;
            btnResetData.BackColor = Color.Gainsboro;
            btnResetData.Cursor = Cursors.Hand;
            btnResetData.Enabled = false;
            btnResetData.FlatStyle = FlatStyle.Popup;
            btnResetData.Location = new Point(64, 932);
            btnResetData.Name = "btnResetData";
            btnResetData.Size = new Size(159, 28);
            btnResetData.TabIndex = 13;
            btnResetData.Text = "RESET DATA";
            btnResetData.UseVisualStyleBackColor = false;
            btnResetData.Click += btnResetData_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top;
            pictureBox9.BackgroundImage = Properties.Resources.box;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(30, 650);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(28, 28);
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            // 
            // labelIDUser
            // 
            labelIDUser.AutoSize = true;
            labelIDUser.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIDUser.Location = new Point(156, 247);
            labelIDUser.Name = "labelIDUser";
            labelIDUser.Size = new Size(0, 18);
            labelIDUser.TabIndex = 3;
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.Top;
            pictureBox14.BackgroundImage = Properties.Resources.card_file__box_emoji;
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Location = new Point(31, 333);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(28, 28);
            pictureBox14.TabIndex = 12;
            pictureBox14.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Anchor = AnchorStyles.Top;
            pictureBox19.BackgroundImage = Properties.Resources.restore;
            pictureBox19.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox19.Location = new Point(29, 898);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(28, 28);
            pictureBox19.TabIndex = 34;
            pictureBox19.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 703);
            label5.Name = "label5";
            label5.Size = new Size(94, 18);
            label5.TabIndex = 21;
            label5.Text = "LAPORAN";
            // 
            // btnData_Barang
            // 
            btnData_Barang.Anchor = AnchorStyles.Top;
            btnData_Barang.BackColor = Color.Gainsboro;
            btnData_Barang.BackgroundImageLayout = ImageLayout.None;
            btnData_Barang.Cursor = Cursors.Hand;
            btnData_Barang.Enabled = false;
            btnData_Barang.FlatStyle = FlatStyle.Popup;
            btnData_Barang.ImageAlign = ContentAlignment.MiddleLeft;
            btnData_Barang.Location = new Point(65, 333);
            btnData_Barang.Name = "btnData_Barang";
            btnData_Barang.Size = new Size(160, 28);
            btnData_Barang.TabIndex = 1;
            btnData_Barang.Text = "DATA BARANG";
            btnData_Barang.UseVisualStyleBackColor = false;
            btnData_Barang.Click += btnData_Barang_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 526);
            label6.Name = "label6";
            label6.Size = new Size(107, 18);
            label6.TabIndex = 11;
            label6.Text = "AKTIVITAS";
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top;
            btnRestore.BackColor = Color.Gainsboro;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Enabled = false;
            btnRestore.FlatStyle = FlatStyle.Popup;
            btnRestore.Location = new Point(64, 898);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(159, 28);
            btnRestore.TabIndex = 12;
            btnRestore.Text = "RESTORE";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Anchor = AnchorStyles.Top;
            btnTransaksi.BackColor = Color.Gainsboro;
            btnTransaksi.Cursor = Cursors.Hand;
            btnTransaksi.Enabled = false;
            btnTransaksi.FlatStyle = FlatStyle.Popup;
            btnTransaksi.Location = new Point(65, 725);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(159, 28);
            btnTransaksi.TabIndex = 8;
            btnTransaksi.Text = "AKTIVITAS";
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // pctUser
            // 
            pctUser.Anchor = AnchorStyles.Top;
            pctUser.BackgroundImage = (Image)resources.GetObject("pctUser.BackgroundImage");
            pctUser.BackgroundImageLayout = ImageLayout.Zoom;
            pctUser.BorderStyle = BorderStyle.FixedSingle;
            pctUser.Location = new Point(48, 22);
            pctUser.Name = "pctUser";
            pctUser.Size = new Size(150, 155);
            pctUser.TabIndex = 0;
            pctUser.TabStop = false;
            // 
            // btnData_Petugas
            // 
            btnData_Petugas.Anchor = AnchorStyles.Top;
            btnData_Petugas.BackColor = Color.Gainsboro;
            btnData_Petugas.Cursor = Cursors.Hand;
            btnData_Petugas.Enabled = false;
            btnData_Petugas.FlatStyle = FlatStyle.Popup;
            btnData_Petugas.Location = new Point(65, 469);
            btnData_Petugas.Name = "btnData_Petugas";
            btnData_Petugas.Size = new Size(159, 28);
            btnData_Petugas.TabIndex = 5;
            btnData_Petugas.Text = "DATA PETUGAS";
            btnData_Petugas.UseVisualStyleBackColor = false;
            btnData_Petugas.Click += btnData_Petugas_Click;
            // 
            // pictureBox20
            // 
            pictureBox20.Anchor = AnchorStyles.Top;
            pictureBox20.BackgroundImage = Properties.Resources.backup;
            pictureBox20.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox20.Location = new Point(29, 864);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(28, 28);
            pictureBox20.TabIndex = 32;
            pictureBox20.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Anchor = AnchorStyles.Top;
            pictureBox16.BackgroundImage = Properties.Resources.data;
            pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox16.Location = new Point(31, 725);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(28, 28);
            pictureBox16.TabIndex = 23;
            pictureBox16.TabStop = false;
            // 
            // labelNamaUser
            // 
            labelNamaUser.AutoSize = true;
            labelNamaUser.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaUser.Location = new Point(156, 190);
            labelNamaUser.Name = "labelNamaUser";
            labelNamaUser.Size = new Size(0, 18);
            labelNamaUser.TabIndex = 1;
            // 
            // btnData_Kelas
            // 
            btnData_Kelas.Anchor = AnchorStyles.Top;
            btnData_Kelas.BackColor = Color.Gainsboro;
            btnData_Kelas.Cursor = Cursors.Hand;
            btnData_Kelas.Enabled = false;
            btnData_Kelas.FlatStyle = FlatStyle.Popup;
            btnData_Kelas.Location = new Point(65, 435);
            btnData_Kelas.Name = "btnData_Kelas";
            btnData_Kelas.Size = new Size(159, 28);
            btnData_Kelas.TabIndex = 4;
            btnData_Kelas.Text = "DATA KELAS";
            btnData_Kelas.UseVisualStyleBackColor = false;
            btnData_Kelas.Click += btnData_Kelas_Click;
            // 
            // btnBackup
            // 
            btnBackup.Anchor = AnchorStyles.Top;
            btnBackup.BackColor = Color.Gainsboro;
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.Enabled = false;
            btnBackup.FlatStyle = FlatStyle.Popup;
            btnBackup.Location = new Point(64, 864);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(159, 28);
            btnBackup.TabIndex = 11;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // labelJabatanUser
            // 
            labelJabatanUser.AutoSize = true;
            labelJabatanUser.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJabatanUser.Location = new Point(156, 221);
            labelJabatanUser.Name = "labelJabatanUser";
            labelJabatanUser.Size = new Size(0, 18);
            labelJabatanUser.TabIndex = 2;
            // 
            // btnData_Guru
            // 
            btnData_Guru.Anchor = AnchorStyles.Top;
            btnData_Guru.BackColor = Color.Gainsboro;
            btnData_Guru.Cursor = Cursors.Hand;
            btnData_Guru.Enabled = false;
            btnData_Guru.FlatStyle = FlatStyle.Popup;
            btnData_Guru.Location = new Point(65, 401);
            btnData_Guru.Name = "btnData_Guru";
            btnData_Guru.Size = new Size(159, 28);
            btnData_Guru.TabIndex = 3;
            btnData_Guru.Text = "DATA GURU";
            btnData_Guru.UseVisualStyleBackColor = false;
            btnData_Guru.Click += btnData_Guru_Click;
            // 
            // pictureBox18
            // 
            pictureBox18.Anchor = AnchorStyles.Top;
            pictureBox18.BackgroundImage = Properties.Resources.login_icon;
            pictureBox18.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox18.Location = new Point(29, 830);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(28, 28);
            pictureBox18.TabIndex = 28;
            pictureBox18.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-1, 286);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 2);
            panel4.TabIndex = 4;
            // 
            // btnData_Siswa
            // 
            btnData_Siswa.Anchor = AnchorStyles.Top;
            btnData_Siswa.BackColor = Color.Gainsboro;
            btnData_Siswa.Cursor = Cursors.Hand;
            btnData_Siswa.Enabled = false;
            btnData_Siswa.FlatStyle = FlatStyle.Popup;
            btnData_Siswa.Location = new Point(65, 367);
            btnData_Siswa.Name = "btnData_Siswa";
            btnData_Siswa.Size = new Size(159, 28);
            btnData_Siswa.TabIndex = 2;
            btnData_Siswa.Text = "DATA SISWA";
            btnData_Siswa.UseVisualStyleBackColor = false;
            btnData_Siswa.Click += btnData_Siswa_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 809);
            label11.Name = "label11";
            label11.Size = new Size(76, 18);
            label11.TabIndex = 26;
            label11.Text = "SISTEM";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 312);
            label7.Name = "label7";
            label7.Size = new Size(136, 18);
            label7.TabIndex = 6;
            label7.Text = "DATA MASTER";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(statusStrip1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 1031);
            panel5.Name = "panel5";
            panel5.Size = new Size(1296, 30);
            panel5.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStripLabelStatus, statusStripLabelDateTime });
            statusStrip1.Location = new Point(0, 3);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1294, 25);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabelStatus
            // 
            statusStripLabelStatus.BorderSides = ToolStripStatusLabelBorderSides.Right;
            statusStripLabelStatus.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusStripLabelStatus.Margin = new Padding(5, 3, 0, 2);
            statusStripLabelStatus.Name = "statusStripLabelStatus";
            statusStripLabelStatus.Padding = new Padding(0, 0, 2, 0);
            statusStripLabelStatus.Size = new Size(244, 20);
            statusStripLabelStatus.Text = "Status : Terhubung ke Database";
            // 
            // statusStripLabelDateTime
            // 
            statusStripLabelDateTime.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusStripLabelDateTime.Margin = new Padding(10, 3, 0, 2);
            statusStripLabelDateTime.Name = "statusStripLabelDateTime";
            statusStripLabelDateTime.Size = new Size(320, 20);
            statusStripLabelDateTime.Text = "Selasa, 24 September 2025 | 09:45:30 WIB";
            // 
            // btnLaporKerusakan
            // 
            btnLaporKerusakan.Anchor = AnchorStyles.Top;
            btnLaporKerusakan.BackColor = Color.Gainsboro;
            btnLaporKerusakan.Cursor = Cursors.Hand;
            btnLaporKerusakan.Enabled = false;
            btnLaporKerusakan.FlatStyle = FlatStyle.Popup;
            btnLaporKerusakan.Location = new Point(65, 759);
            btnLaporKerusakan.Name = "btnLaporKerusakan";
            btnLaporKerusakan.Size = new Size(159, 28);
            btnLaporKerusakan.TabIndex = 47;
            btnLaporKerusakan.Text = "KERUSAKAN";
            btnLaporKerusakan.UseVisualStyleBackColor = false;
            btnLaporKerusakan.Click += btnLaporKerusakan_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackgroundImage = Properties.Resources.kerusakan;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(31, 759);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 28);
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // Menu_Utama
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 1061);
            Controls.Add(panel3);
            Controls.Add(panelTop);
            Controls.Add(panel5);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Menu_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Utama";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Utama_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBox1;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Button btnDataKelas;
        private Button btnndataGuru;
        private Button btnDataSiswa;
        private Button btnDataBarang;
        private Button btnDataPetugas;
        private Button btnPembelian;
        private Button btnPermintaan;
        private Panel panel3;
        private PictureBox pictureBox16;
        private Button btnTransaksi;
        private Label label5;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label label6;
        private Button btnData_Petugas;
        private Button btnData_Kelas;
        private Button btnData_Guru;
        private Button btnData_Siswa;
        private Label label7;
        private Panel panel4;
        private Label labelIDUser;
        private Label labelJabatanUser;
        private Label labelNamaUser;
        private PictureBox pctUser;
        private Button btnData_Barang;
        private PictureBox pictureBox20;
        private Button btnBackup;
        private PictureBox pictureBox18;
        private Button btnLogin;
        private Label label11;
        private PictureBox pictureBox21;
        private Button btnResetData;
        private PictureBox pictureBox19;
        private Button btnRestore;
        private Button btn_Pembelian;
        private Button btn_Permintaan;
        private Panel panel5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStripLabelStatus;
        private ToolStripStatusLabel statusStripLabelDateTime;
        private System.Windows.Forms.Timer waktu;
        private Button btnLogout;
        private Label lblJabatan;
        private Label lblNamaPetugas;
        private Label lblIDPetugas;
        private Label titik1;
        private Label titik3;
        private Label titik2;
        private Button btn_Peminjaman;
        private PictureBox pictureBox2;
        private Button btn_Pengembalian;
        private PictureBox pictureBox3;
        private Button btnLaporKerusakan;
        private PictureBox pictureBox4;
    }
}
