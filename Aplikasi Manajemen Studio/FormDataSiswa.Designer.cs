namespace Aplikasi_Manajemen_Studio
{
    partial class FormDataSiswa
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            cmbFilterTingkat = new ComboBox();
            btnImpor = new Button();
            btnEkspor = new Button();
            cmbKelas = new ComboBox();
            btnTutup = new Button();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnTambah = new Button();
            txtNamaSiswa = new TextBox();
            txtNisn = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvSiswa = new DataGridView();
            txtCari = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbFilterTingkat);
            groupBox1.Controls.Add(btnImpor);
            groupBox1.Controls.Add(btnEkspor);
            groupBox1.Controls.Add(cmbKelas);
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnBatal);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnUbah);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(txtNamaSiswa);
            groupBox1.Controls.Add(txtNisn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1003, 395);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data Siswa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label4.Location = new Point(410, 324);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 19;
            label4.Text = "Filter Tingkat:";
            // 
            // cmbFilterTingkat
            // 
            cmbFilterTingkat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterTingkat.FormattingEnabled = true;
            cmbFilterTingkat.Location = new Point(581, 321);
            cmbFilterTingkat.Name = "cmbFilterTingkat";
            cmbFilterTingkat.Size = new Size(237, 31);
            cmbFilterTingkat.TabIndex = 18;
            cmbFilterTingkat.SelectedIndexChanged += cmbFilterTingkat_SelectedIndexChanged;
            // 
            // btnImpor
            // 
            btnImpor.BackColor = Color.DarkOrange;
            btnImpor.Cursor = Cursors.Hand;
            btnImpor.FlatStyle = FlatStyle.Popup;
            btnImpor.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImpor.ForeColor = Color.White;
            btnImpor.Location = new Point(24, 316);
            btnImpor.Name = "btnImpor";
            btnImpor.Size = new Size(153, 43);
            btnImpor.TabIndex = 16;
            btnImpor.Text = "Import Data";
            btnImpor.UseVisualStyleBackColor = false;
            btnImpor.Click += btnImpor_Click;
            // 
            // btnEkspor
            // 
            btnEkspor.BackColor = Color.DarkOrange;
            btnEkspor.Cursor = Cursors.Hand;
            btnEkspor.FlatStyle = FlatStyle.Popup;
            btnEkspor.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkspor.ForeColor = Color.White;
            btnEkspor.Location = new Point(213, 316);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(153, 43);
            btnEkspor.TabIndex = 17;
            btnEkspor.Text = "Ekspor Data";
            btnEkspor.UseVisualStyleBackColor = false;
            btnEkspor.Click += btnEkspor_Click;
            // 
            // cmbKelas
            // 
            cmbKelas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKelas.FormattingEnabled = true;
            cmbKelas.Location = new Point(605, 56);
            cmbKelas.Name = "cmbKelas";
            cmbKelas.Size = new Size(213, 31);
            cmbKelas.TabIndex = 3;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Maroon;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(797, 208);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(153, 45);
            btnTutup.TabIndex = 8;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.DodgerBlue;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(605, 208);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(153, 45);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Firebrick;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Popup;
            btnHapus.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(410, 208);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(153, 45);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.Goldenrod;
            btnUbah.Cursor = Cursors.Hand;
            btnUbah.FlatStyle = FlatStyle.Popup;
            btnUbah.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(213, 208);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(153, 45);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.OliveDrab;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(24, 208);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(153, 45);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtNamaSiswa
            // 
            txtNamaSiswa.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtNamaSiswa.Location = new Point(213, 116);
            txtNamaSiswa.Name = "txtNamaSiswa";
            txtNamaSiswa.Size = new Size(221, 31);
            txtNamaSiswa.TabIndex = 2;
            // 
            // txtNisn
            // 
            txtNisn.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtNisn.Location = new Point(213, 56);
            txtNisn.Name = "txtNisn";
            txtNisn.Size = new Size(221, 31);
            txtNisn.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label7.Location = new Point(581, 59);
            label7.Name = "label7";
            label7.Size = new Size(18, 23);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label6.Location = new Point(185, 119);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 6;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label5.Location = new Point(185, 59);
            label5.Name = "label5";
            label5.Size = new Size(18, 23);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label3.Location = new Point(476, 59);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 3;
            label3.Text = "Kelas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 119);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 2;
            label2.Text = "Nama Siswa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 1;
            label1.Text = "NISN";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvSiswa);
            panel1.Controls.Add(txtCari);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 193);
            panel1.TabIndex = 2;
            // 
            // dgvSiswa
            // 
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Dock = DockStyle.Fill;
            dgvSiswa.Location = new Point(0, 44);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.Size = new Size(1001, 147);
            dgvSiswa.TabIndex = 14;
            dgvSiswa.CellClick += dgvSiswa_CellClick;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Dock = DockStyle.Top;
            txtCari.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            txtCari.Location = new Point(0, 18);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(1001, 26);
            txtCari.TabIndex = 9;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 18);
            label10.TabIndex = 11;
            label10.Text = "Cari Siswa :";
            // 
            // FormDataSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 588);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDataSiswa";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormDataSiswa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnTambah;
        private TextBox txtNamaSiswa;
        private TextBox txtNisn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvSiswa;
        private TextBox txtCari;
        private Label label10;
        private ComboBox cmbKelas;
        private Button btnImpor;
        private Button btnEkspor;
        private Label label4;
        private ComboBox cmbFilterTingkat;
    }
}