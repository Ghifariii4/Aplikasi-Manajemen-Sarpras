namespace Aplikasi_Manajemen_Studio
{
    partial class FormPengembalian
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
            panelTop = new Panel();
            label1 = new Label();
            btnTutup = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            rbSiswa = new RadioButton();
            btnCariPeminjam = new Button();
            txtNamaPeminjam = new TextBox();
            rbGuru = new RadioButton();
            groupBox2 = new GroupBox();
            dgvBarangDipinjam = new DataGridView();
            colPilih = new DataGridViewCheckBoxColumn();
            ID_Peminjaman = new DataGridViewTextBoxColumn();
            Nama_Barang = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Tgl_Pinjam = new DataGridViewTextBoxColumn();
            Tgl_JatuhTempo = new DataGridViewTextBoxColumn();
            btnBatal = new Button();
            btnProsesPengembalian = new Button();
            panel2 = new Panel();
            panelTop.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarangDipinjam).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnTutup);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1224, 50);
            panelTop.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(238, 18);
            label1.TabIndex = 0;
            label1.Text = "Form Pengembalian - AMS";
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Red;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.Dock = DockStyle.Right;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.Black;
            btnTutup.Location = new Point(1134, 0);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(88, 48);
            btnTutup.TabIndex = 0;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 17);
            panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(rbSiswa);
            groupBox1.Controls.Add(btnCariPeminjam);
            groupBox1.Controls.Add(txtNamaPeminjam);
            groupBox1.Controls.Add(rbGuru);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1224, 110);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEMINJAM :";
            // 
            // rbSiswa
            // 
            rbSiswa.AutoSize = true;
            rbSiswa.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSiswa.Location = new Point(159, 45);
            rbSiswa.Name = "rbSiswa";
            rbSiswa.Size = new Size(92, 27);
            rbSiswa.TabIndex = 3;
            rbSiswa.TabStop = true;
            rbSiswa.Text = "Siswa";
            rbSiswa.UseVisualStyleBackColor = true;
            rbSiswa.CheckedChanged += rbGuru_Siswa_CheckedChanged;
            // 
            // btnCariPeminjam
            // 
            btnCariPeminjam.BackColor = Color.Firebrick;
            btnCariPeminjam.Cursor = Cursors.Hand;
            btnCariPeminjam.FlatStyle = FlatStyle.Popup;
            btnCariPeminjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCariPeminjam.ForeColor = Color.White;
            btnCariPeminjam.Location = new Point(299, 42);
            btnCariPeminjam.Name = "btnCariPeminjam";
            btnCariPeminjam.Size = new Size(157, 30);
            btnCariPeminjam.TabIndex = 2;
            btnCariPeminjam.Text = "Cari Peminjam";
            btnCariPeminjam.UseVisualStyleBackColor = false;
            btnCariPeminjam.Click += btnCariPeminjam_Click;
            // 
            // txtNamaPeminjam
            // 
            txtNamaPeminjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNamaPeminjam.Location = new Point(471, 45);
            txtNamaPeminjam.Name = "txtNamaPeminjam";
            txtNamaPeminjam.PlaceholderText = "Nama Peminjam";
            txtNamaPeminjam.ReadOnly = true;
            txtNamaPeminjam.Size = new Size(359, 27);
            txtNamaPeminjam.TabIndex = 1;
            txtNamaPeminjam.TextAlign = HorizontalAlignment.Center;
            // 
            // rbGuru
            // 
            rbGuru.AutoSize = true;
            rbGuru.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbGuru.Location = new Point(44, 45);
            rbGuru.Name = "rbGuru";
            rbGuru.Size = new Size(80, 27);
            rbGuru.TabIndex = 0;
            rbGuru.TabStop = true;
            rbGuru.Text = "Guru";
            rbGuru.UseVisualStyleBackColor = true;
            rbGuru.CheckedChanged += rbGuru_Siswa_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(dgvBarangDipinjam);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1224, 392);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Daftar Barang yang Sedang Dipinjam:  ";
            // 
            // dgvBarangDipinjam
            // 
            dgvBarangDipinjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarangDipinjam.Columns.AddRange(new DataGridViewColumn[] { colPilih, ID_Peminjaman, Nama_Barang, Jumlah, Tgl_Pinjam, Tgl_JatuhTempo });
            dgvBarangDipinjam.Dock = DockStyle.Fill;
            dgvBarangDipinjam.Location = new Point(3, 23);
            dgvBarangDipinjam.Name = "dgvBarangDipinjam";
            dgvBarangDipinjam.Size = new Size(1218, 366);
            dgvBarangDipinjam.TabIndex = 14;
            dgvBarangDipinjam.CellFormatting += dgvBarangDipinjam_CellFormatting;
            // 
            // colPilih
            // 
            colPilih.FillWeight = 11.9148932F;
            colPilih.HeaderText = "Pilih";
            colPilih.Name = "colPilih";
            colPilih.Resizable = DataGridViewTriState.True;
            colPilih.SortMode = DataGridViewColumnSortMode.Automatic;
            colPilih.Width = 68;
            // 
            // ID_Peminjaman
            // 
            ID_Peminjaman.DataPropertyName = "ID_Peminjaman";
            ID_Peminjaman.HeaderText = "ID Peminjaman";
            ID_Peminjaman.Name = "ID_Peminjaman";
            ID_Peminjaman.Visible = false;
            // 
            // Nama_Barang
            // 
            Nama_Barang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama_Barang.DataPropertyName = "Nama_Barang";
            Nama_Barang.FillWeight = 188.085129F;
            Nama_Barang.HeaderText = "Nama Barang";
            Nama_Barang.Name = "Nama_Barang";
            // 
            // Jumlah
            // 
            Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jumlah.DataPropertyName = "Jumlah";
            Jumlah.HeaderText = "Jumlah";
            Jumlah.Name = "Jumlah";
            // 
            // Tgl_Pinjam
            // 
            Tgl_Pinjam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tgl_Pinjam.DataPropertyName = "Tgl_Pinjam";
            Tgl_Pinjam.HeaderText = "Tanggal Pinjam";
            Tgl_Pinjam.Name = "Tgl_Pinjam";
            // 
            // Tgl_JatuhTempo
            // 
            Tgl_JatuhTempo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tgl_JatuhTempo.DataPropertyName = "Tgl_JatuhTempo";
            Tgl_JatuhTempo.HeaderText = "Jatuh Tempo";
            Tgl_JatuhTempo.Name = "Tgl_JatuhTempo";
            // 
            // btnBatal
            // 
            btnBatal.Anchor = AnchorStyles.Top;
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(598, 18);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(276, 58);
            btnBatal.TabIndex = 15;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnProsesPengembalian
            // 
            btnProsesPengembalian.Anchor = AnchorStyles.Top;
            btnProsesPengembalian.BackColor = Color.OliveDrab;
            btnProsesPengembalian.Cursor = Cursors.Hand;
            btnProsesPengembalian.FlatStyle = FlatStyle.Popup;
            btnProsesPengembalian.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsesPengembalian.ForeColor = Color.White;
            btnProsesPengembalian.Location = new Point(276, 18);
            btnProsesPengembalian.Name = "btnProsesPengembalian";
            btnProsesPengembalian.Size = new Size(285, 58);
            btnProsesPengembalian.TabIndex = 14;
            btnProsesPengembalian.Text = "Proses Pengembalian";
            btnProsesPengembalian.UseVisualStyleBackColor = false;
            btnProsesPengembalian.Click += btnProsesPengembalian_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(btnBatal);
            panel2.Controls.Add(btnProsesPengembalian);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 474);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 95);
            panel2.TabIndex = 14;
            // 
            // FormPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 569);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPengembalian";
            Load += FormPengembalian_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarangDipinjam).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label1;
        private Button btnTutup;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnCariPeminjam;
        private TextBox txtNamaPeminjam;
        private RadioButton rbGuru;
        private GroupBox groupBox2;
        private DataGridView dgvBarangDipinjam;
        private Button btnBatal;
        private Button btnProsesPengembalian;
        private Panel panel2;
        private DataGridViewCheckBoxColumn colPilih;
        private DataGridViewTextBoxColumn ID_Peminjaman;
        private DataGridViewTextBoxColumn Nama_Barang;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Tgl_Pinjam;
        private DataGridViewTextBoxColumn Tgl_JatuhTempo;
        private RadioButton rbSiswa;
    }
}