namespace Aplikasi_Manajemen_Studio
{
    partial class FormPermintaan
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
            btnExit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnTambahKeKeranjang = new Button();
            numJumlah = new NumericUpDown();
            label3 = new Label();
            cmbBarang = new ComboBox();
            label2 = new Label();
            rbGuru = new RadioButton();
            rbSiswa = new RadioButton();
            txtNamaPemohon = new TextBox();
            btncaripemohon = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvKeranjang = new DataGridView();
            panel3 = new Panel();
            btnDetailTransaksi = new Button();
            btnBatalTransaksi = new Button();
            btnSimpanTransaksi = new Button();
            panel4 = new Panel();
            label5 = new Label();
            lblTotalBarang = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
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
            panelTop.Size = new Size(1224, 50);
            panelTop.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(216, 18);
            label1.TabIndex = 0;
            label1.Text = "Form Permintaan - AMS";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1134, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "Tutup";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnTutup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 17);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(btnTambahKeKeranjang);
            panel2.Controls.Add(numJumlah);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbBarang);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 289);
            panel2.TabIndex = 5;
            // 
            // btnTambahKeKeranjang
            // 
            btnTambahKeKeranjang.BackColor = Color.OliveDrab;
            btnTambahKeKeranjang.Cursor = Cursors.Hand;
            btnTambahKeKeranjang.FlatStyle = FlatStyle.Popup;
            btnTambahKeKeranjang.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahKeKeranjang.ForeColor = Color.White;
            btnTambahKeKeranjang.Location = new Point(12, 220);
            btnTambahKeKeranjang.Name = "btnTambahKeKeranjang";
            btnTambahKeKeranjang.Size = new Size(216, 34);
            btnTambahKeKeranjang.TabIndex = 4;
            btnTambahKeKeranjang.Text = "Tambah Barang";
            btnTambahKeKeranjang.UseVisualStyleBackColor = false;
            btnTambahKeKeranjang.Click += btnTambahBarang_Click;
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(12, 154);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(216, 31);
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
            cmbBarang.Size = new Size(216, 31);
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
            // rbGuru
            // 
            rbGuru.AutoSize = true;
            rbGuru.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbGuru.Location = new Point(12, 50);
            rbGuru.Name = "rbGuru";
            rbGuru.Size = new Size(69, 22);
            rbGuru.TabIndex = 0;
            rbGuru.TabStop = true;
            rbGuru.Text = "Guru";
            rbGuru.UseVisualStyleBackColor = true;
            rbGuru.CheckedChanged += rbGuru_Siswa_CheckedChanged;
            // 
            // rbSiswa
            // 
            rbSiswa.AutoSize = true;
            rbSiswa.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSiswa.Location = new Point(97, 50);
            rbSiswa.Name = "rbSiswa";
            rbSiswa.Size = new Size(77, 22);
            rbSiswa.TabIndex = 1;
            rbSiswa.TabStop = true;
            rbSiswa.Text = "Siswa";
            rbSiswa.UseVisualStyleBackColor = true;
            rbSiswa.CheckedChanged += rbGuru_Siswa_CheckedChanged;
            // 
            // txtNamaPemohon
            // 
            txtNamaPemohon.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNamaPemohon.Location = new Point(404, 45);
            txtNamaPemohon.Name = "txtNamaPemohon";
            txtNamaPemohon.PlaceholderText = "Nama Pemohon";
            txtNamaPemohon.ReadOnly = true;
            txtNamaPemohon.Size = new Size(359, 27);
            txtNamaPemohon.TabIndex = 1;
            txtNamaPemohon.TextAlign = HorizontalAlignment.Center;
            // 
            // btncaripemohon
            // 
            btncaripemohon.BackColor = Color.Firebrick;
            btncaripemohon.Cursor = Cursors.Hand;
            btncaripemohon.FlatStyle = FlatStyle.Popup;
            btncaripemohon.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncaripemohon.ForeColor = Color.White;
            btncaripemohon.Location = new Point(232, 42);
            btncaripemohon.Name = "btncaripemohon";
            btncaripemohon.Size = new Size(157, 30);
            btncaripemohon.TabIndex = 2;
            btncaripemohon.Text = "Cari Pemohon";
            btncaripemohon.UseVisualStyleBackColor = false;
            btncaripemohon.Click += btnCariPemohon_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btncaripemohon);
            groupBox1.Controls.Add(txtNamaPemohon);
            groupBox1.Controls.Add(rbSiswa);
            groupBox1.Controls.Add(rbGuru);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1224, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEMOHON :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(dgvKeranjang);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(295, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(929, 289);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "KERANJANG :";
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Dock = DockStyle.Fill;
            dgvKeranjang.Location = new Point(3, 27);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.ReadOnly = true;
            dgvKeranjang.Size = new Size(923, 259);
            dgvKeranjang.TabIndex = 0;
            dgvKeranjang.CellClick += dgvKeranjang_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(btnDetailTransaksi);
            panel3.Controls.Add(btnBatalTransaksi);
            panel3.Controls.Add(btnSimpanTransaksi);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 466);
            panel3.Name = "panel3";
            panel3.Size = new Size(1224, 103);
            panel3.TabIndex = 7;
            // 
            // btnDetailTransaksi
            // 
            btnDetailTransaksi.Anchor = AnchorStyles.Top;
            btnDetailTransaksi.BackColor = Color.Orange;
            btnDetailTransaksi.Cursor = Cursors.Hand;
            btnDetailTransaksi.FlatStyle = FlatStyle.Popup;
            btnDetailTransaksi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetailTransaksi.ForeColor = Color.White;
            btnDetailTransaksi.Location = new Point(915, 24);
            btnDetailTransaksi.Name = "btnDetailTransaksi";
            btnDetailTransaksi.Size = new Size(202, 58);
            btnDetailTransaksi.TabIndex = 7;
            btnDetailTransaksi.Text = "Detail";
            btnDetailTransaksi.UseVisualStyleBackColor = false;
            btnDetailTransaksi.Click += btnDetail_Click;
            // 
            // btnBatalTransaksi
            // 
            btnBatalTransaksi.Anchor = AnchorStyles.Top;
            btnBatalTransaksi.BackColor = Color.Firebrick;
            btnBatalTransaksi.Cursor = Cursors.Hand;
            btnBatalTransaksi.FlatStyle = FlatStyle.Popup;
            btnBatalTransaksi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatalTransaksi.ForeColor = Color.White;
            btnBatalTransaksi.Location = new Point(649, 24);
            btnBatalTransaksi.Name = "btnBatalTransaksi";
            btnBatalTransaksi.Size = new Size(202, 58);
            btnBatalTransaksi.TabIndex = 6;
            btnBatalTransaksi.Text = "Batal";
            btnBatalTransaksi.UseVisualStyleBackColor = false;
            btnBatalTransaksi.Click += btnBatal_Click;
            // 
            // btnSimpanTransaksi
            // 
            btnSimpanTransaksi.Anchor = AnchorStyles.Top;
            btnSimpanTransaksi.BackColor = Color.OliveDrab;
            btnSimpanTransaksi.Cursor = Cursors.Hand;
            btnSimpanTransaksi.FlatStyle = FlatStyle.Popup;
            btnSimpanTransaksi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanTransaksi.ForeColor = Color.White;
            btnSimpanTransaksi.Location = new Point(385, 24);
            btnSimpanTransaksi.Name = "btnSimpanTransaksi";
            btnSimpanTransaksi.Size = new Size(202, 58);
            btnSimpanTransaksi.TabIndex = 4;
            btnSimpanTransaksi.Text = "Simpan";
            btnSimpanTransaksi.UseVisualStyleBackColor = false;
            btnSimpanTransaksi.Click += btnSimpan_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblTotalBarang);
            panel4.Location = new Point(12, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 58);
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
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.BackColor = Color.Wheat;
            lblTotalBarang.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalBarang.ForeColor = Color.DarkRed;
            lblTotalBarang.Location = new Point(220, 16);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(27, 25);
            lblTotalBarang.TabIndex = 5;
            lblTotalBarang.Text = "0";
            // 
            // FormPermintaan
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 569);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panel3);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPermintaan";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormPermintaan_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Label label1;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private ComboBox cmbBarang;
        private Button btnTambahKeKeranjang;
        private NumericUpDown numJumlah;
        private Label label3;
        private RadioButton rbGuru;
        private RadioButton rbSiswa;
        private TextBox txtNamaPemohon;
        private Button btncaripemohon;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvKeranjang;
        private Panel panel3;
        private Button btnSimpanTransaksi;
        private Label label5;
        private Label lblTotalBarang;
        private Button btnDetailTransaksi;
        private Button btnBatalTransaksi;
        private Panel panel4;
    }
}