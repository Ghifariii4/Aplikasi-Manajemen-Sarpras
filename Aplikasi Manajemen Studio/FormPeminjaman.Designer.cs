namespace Aplikasi_Manajemen_Studio
{
    partial class FormPeminjaman
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
            lblTotalItem = new Label();
            btnDetailTransaksi = new Button();
            btnBatal = new Button();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            btnSimpanPinjam = new Button();
            dgvKeranjangPinjam = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnCariPeminjam = new Button();
            txtNamaPeminjam = new TextBox();
            rbSiswa = new RadioButton();
            rbGuru = new RadioButton();
            btnTambahKeKeranjang = new Button();
            numJumlah = new NumericUpDown();
            label3 = new Label();
            cmbBarang = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            cbTanpaBatasWaktu = new CheckBox();
            lblTglJatuhTempoOtomatis = new Label();
            label6 = new Label();
            cmbSatuanDurasi = new ComboBox();
            numDurasi = new NumericUpDown();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Button();
            panelTop = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjangPinjam).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasi).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.BackColor = Color.Wheat;
            lblTotalItem.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalItem.ForeColor = Color.DarkRed;
            lblTotalItem.Location = new Point(220, 16);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(27, 25);
            lblTotalItem.TabIndex = 5;
            lblTotalItem.Text = "0";
            // 
            // btnDetailTransaksi
            // 
            btnDetailTransaksi.Anchor = AnchorStyles.Top;
            btnDetailTransaksi.BackColor = Color.Orange;
            btnDetailTransaksi.Cursor = Cursors.Hand;
            btnDetailTransaksi.FlatStyle = FlatStyle.Popup;
            btnDetailTransaksi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetailTransaksi.ForeColor = Color.White;
            btnDetailTransaksi.Location = new Point(1530, 24);
            btnDetailTransaksi.Name = "btnDetailTransaksi";
            btnDetailTransaksi.Size = new Size(202, 58);
            btnDetailTransaksi.TabIndex = 7;
            btnDetailTransaksi.Text = "Detail";
            btnDetailTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.Anchor = AnchorStyles.Top;
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(896, 24);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(202, 58);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblTotalItem);
            panel4.Location = new Point(12, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 58);
            panel4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 16);
            label5.Name = "label5";
            label5.Size = new Size(208, 25);
            label5.TabIndex = 0;
            label5.Text = "TOTAL BARANG :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(btnDetailTransaksi);
            panel3.Controls.Add(btnBatal);
            panel3.Controls.Add(btnSimpanPinjam);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 761);
            panel3.Name = "panel3";
            panel3.Size = new Size(1430, 103);
            panel3.TabIndex = 13;
            // 
            // btnSimpanPinjam
            // 
            btnSimpanPinjam.Anchor = AnchorStyles.Top;
            btnSimpanPinjam.BackColor = Color.OliveDrab;
            btnSimpanPinjam.Cursor = Cursors.Hand;
            btnSimpanPinjam.FlatStyle = FlatStyle.Popup;
            btnSimpanPinjam.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanPinjam.ForeColor = Color.White;
            btnSimpanPinjam.Location = new Point(634, 24);
            btnSimpanPinjam.Name = "btnSimpanPinjam";
            btnSimpanPinjam.Size = new Size(202, 58);
            btnSimpanPinjam.TabIndex = 4;
            btnSimpanPinjam.Text = "Simpan";
            btnSimpanPinjam.UseVisualStyleBackColor = false;
            btnSimpanPinjam.Click += btnSimpanPinjam_Click;
            // 
            // dgvKeranjangPinjam
            // 
            dgvKeranjangPinjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjangPinjam.Dock = DockStyle.Fill;
            dgvKeranjangPinjam.Location = new Point(3, 27);
            dgvKeranjangPinjam.Name = "dgvKeranjangPinjam";
            dgvKeranjangPinjam.ReadOnly = true;
            dgvKeranjangPinjam.Size = new Size(987, 554);
            dgvKeranjangPinjam.TabIndex = 0;
            dgvKeranjangPinjam.CellClick += dgvKeranjangPinjam_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(dgvKeranjangPinjam);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(437, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(993, 584);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "KERANJANG :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btnCariPeminjam);
            groupBox1.Controls.Add(txtNamaPeminjam);
            groupBox1.Controls.Add(rbSiswa);
            groupBox1.Controls.Add(rbGuru);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1430, 110);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEMINJAM :";
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
            // rbSiswa
            // 
            rbSiswa.AutoSize = true;
            rbSiswa.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            rbSiswa.Location = new Point(156, 45);
            rbSiswa.Name = "rbSiswa";
            rbSiswa.Size = new Size(92, 27);
            rbSiswa.TabIndex = 1;
            rbSiswa.TabStop = true;
            rbSiswa.Text = "Siswa";
            rbSiswa.UseVisualStyleBackColor = true;
            rbSiswa.CheckedChanged += rbGuru_Siswa_CheckedChanged;
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
            // btnTambahKeKeranjang
            // 
            btnTambahKeKeranjang.BackColor = Color.OliveDrab;
            btnTambahKeKeranjang.Cursor = Cursors.Hand;
            btnTambahKeKeranjang.FlatStyle = FlatStyle.Popup;
            btnTambahKeKeranjang.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahKeKeranjang.ForeColor = Color.White;
            btnTambahKeKeranjang.Location = new Point(16, 519);
            btnTambahKeKeranjang.Name = "btnTambahKeKeranjang";
            btnTambahKeKeranjang.Size = new Size(408, 43);
            btnTambahKeKeranjang.TabIndex = 4;
            btnTambahKeKeranjang.Text = "Tambah Barang";
            btnTambahKeKeranjang.UseVisualStyleBackColor = false;
            btnTambahKeKeranjang.Click += btnTambahKeKeranjang_Click;
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(12, 156);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(324, 31);
            numJumlah.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 2;
            label3.Text = "JUMLAH :";
            // 
            // cmbBarang
            // 
            cmbBarang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarang.FormattingEnabled = true;
            cmbBarang.Location = new Point(12, 39);
            cmbBarang.Name = "cmbBarang";
            cmbBarang.Size = new Size(324, 31);
            cmbBarang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 3);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 0;
            label2.Text = "BARANG :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(cbTanpaBatasWaktu);
            panel2.Controls.Add(lblTglJatuhTempoOtomatis);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbSatuanDurasi);
            panel2.Controls.Add(numDurasi);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnTambahKeKeranjang);
            panel2.Controls.Add(numJumlah);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbBarang);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 584);
            panel2.TabIndex = 11;
            // 
            // cbTanpaBatasWaktu
            // 
            cbTanpaBatasWaktu.AutoSize = true;
            cbTanpaBatasWaktu.Location = new Point(12, 435);
            cbTanpaBatasWaktu.Name = "cbTanpaBatasWaktu";
            cbTanpaBatasWaktu.Size = new Size(239, 27);
            cbTanpaBatasWaktu.TabIndex = 10;
            cbTanpaBatasWaktu.Text = "Tanpa Batas Waktu";
            cbTanpaBatasWaktu.UseVisualStyleBackColor = true;
            cbTanpaBatasWaktu.CheckedChanged += cbTanpaBatasWaktu_CheckedChanged;
            // 
            // lblTglJatuhTempoOtomatis
            // 
            lblTglJatuhTempoOtomatis.AutoSize = true;
            lblTglJatuhTempoOtomatis.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTglJatuhTempoOtomatis.ForeColor = Color.Firebrick;
            lblTglJatuhTempoOtomatis.Location = new Point(12, 394);
            lblTglJatuhTempoOtomatis.Name = "lblTglJatuhTempoOtomatis";
            lblTglJatuhTempoOtomatis.Size = new Size(110, 23);
            lblTglJatuhTempoOtomatis.TabIndex = 9;
            lblTglJatuhTempoOtomatis.Text = "10:00:00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 351);
            label6.Name = "label6";
            label6.Size = new Size(208, 23);
            label6.TabIndex = 8;
            label6.Text = "WAKTU KEMBALI :";
            // 
            // cmbSatuanDurasi
            // 
            cmbSatuanDurasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSatuanDurasi.FormattingEnabled = true;
            cmbSatuanDurasi.Items.AddRange(new object[] { "Menit", "Jam", "Hari", "Minggu" });
            cmbSatuanDurasi.Location = new Point(133, 278);
            cmbSatuanDurasi.Name = "cmbSatuanDurasi";
            cmbSatuanDurasi.Size = new Size(203, 31);
            cmbSatuanDurasi.TabIndex = 7;
            cmbSatuanDurasi.SelectedIndexChanged += cmbSatuanDurasi_SelectedIndexChanged;
            // 
            // numDurasi
            // 
            numDurasi.Location = new Point(12, 278);
            numDurasi.Name = "numDurasi";
            numDurasi.Size = new Size(115, 31);
            numDurasi.TabIndex = 6;
            numDurasi.ValueChanged += numDurasi_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(201, 23);
            label4.TabIndex = 5;
            label4.Text = "DURASI PINJAM :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 17);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(223, 18);
            label1.TabIndex = 0;
            label1.Text = "Form Peminjaman - AMS";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1340, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "Tutup";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1430, 50);
            panelTop.TabIndex = 9;
            // 
            // FormPeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 864);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panel3);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPeminjaman";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPeminjaman";
            Load += FormPeminjaman_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjangPinjam).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasi).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTotalItem;
        private Button btnDetailTransaksi;
        private Button btnBatal;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private DataGridView dgvKeranjangPinjam;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnCariPeminjam;
        private TextBox txtNamaPeminjam;
        private RadioButton rbSiswa;
        private RadioButton rbGuru;
        private Button btnTambahKeKeranjang;
        private NumericUpDown numJumlah;
        private Label label3;
        private ComboBox cmbBarang;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Panel panelTop;
        private Button btnSimpanPinjam;
        private Label lblTglJatuhTempoOtomatis;
        private Label label6;
        private ComboBox cmbSatuanDurasi;
        private NumericUpDown numDurasi;
        private Label label4;
        private CheckBox cbTanpaBatasWaktu;
    }
}