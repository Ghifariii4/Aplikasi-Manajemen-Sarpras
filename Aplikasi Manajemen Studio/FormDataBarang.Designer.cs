namespace Aplikasi_Manajemen_Studio
{
    partial class FormDataBarang
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
            txtKeterangan = new TextBox();
            label9 = new Label();
            label11 = new Label();
            btnImpor = new Button();
            btnEkspor = new Button();
            cmbSatuan = new ComboBox();
            btnTutup = new Button();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnTambah = new Button();
            numStok = new NumericUpDown();
            txtNamaBarang = new TextBox();
            txtKodeBarang = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvBarang = new DataGridView();
            txtCari = new TextBox();
            label10 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtKeterangan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnImpor);
            groupBox1.Controls.Add(btnEkspor);
            groupBox1.Controls.Add(cmbSatuan);
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnBatal);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnUbah);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(numStok);
            groupBox1.Controls.Add(txtNamaBarang);
            groupBox1.Controls.Add(txtKodeBarang);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data Barang";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtKeterangan.Location = new Point(213, 178);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(626, 73);
            txtKeterangan.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label9.Location = new Point(185, 178);
            label9.Name = "label9";
            label9.Size = new Size(18, 23);
            label9.TabIndex = 20;
            label9.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label11.Location = new Point(24, 178);
            label11.Name = "label11";
            label11.Size = new Size(136, 23);
            label11.TabIndex = 19;
            label11.Text = "Keterangan";
            // 
            // btnImpor
            // 
            btnImpor.BackColor = Color.DarkOrange;
            btnImpor.Cursor = Cursors.Hand;
            btnImpor.FlatStyle = FlatStyle.Popup;
            btnImpor.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImpor.ForeColor = Color.White;
            btnImpor.Location = new Point(22, 364);
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
            btnEkspor.Location = new Point(211, 364);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(153, 43);
            btnEkspor.TabIndex = 17;
            btnEkspor.Text = "Ekspor Data";
            btnEkspor.UseVisualStyleBackColor = false;
            btnEkspor.Click += btnEkspor_Click;
            // 
            // cmbSatuan
            // 
            cmbSatuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSatuan.Enabled = false;
            cmbSatuan.FormattingEnabled = true;
            cmbSatuan.Items.AddRange(new object[] { "Pcs", "", "", "Unit", "", "", "Buah", "", "", "Set", "", "", "Box", "", "", "Pack", "", "", "Lusin", "", "", "Rim", "", "", "Botol", "", "", "Roll" });
            cmbSatuan.Location = new Point(605, 56);
            cmbSatuan.Name = "cmbSatuan";
            cmbSatuan.Size = new Size(234, 31);
            cmbSatuan.TabIndex = 9;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Maroon;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(795, 282);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(153, 45);
            btnTutup.TabIndex = 8;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnExit_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.DodgerBlue;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(603, 282);
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
            btnHapus.Location = new Point(408, 282);
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
            btnUbah.Location = new Point(211, 282);
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
            btnTambah.Location = new Point(22, 282);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(153, 45);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // numStok
            // 
            numStok.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numStok.Location = new Point(605, 116);
            numStok.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(234, 31);
            numStok.TabIndex = 3;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtNamaBarang.Location = new Point(213, 116);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(221, 31);
            txtNamaBarang.TabIndex = 1;
            // 
            // txtKodeBarang
            // 
            txtKodeBarang.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtKodeBarang.Location = new Point(213, 56);
            txtKodeBarang.Name = "txtKodeBarang";
            txtKodeBarang.ReadOnly = true;
            txtKodeBarang.Size = new Size(221, 31);
            txtKodeBarang.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label8.Location = new Point(581, 119);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 8;
            label8.Text = ":";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label4.Location = new Point(476, 118);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 4;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label3.Location = new Point(476, 59);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 3;
            label3.Text = "Satuan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 119);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 2;
            label2.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvBarang);
            panel1.Controls.Add(txtCari);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 313);
            panel1.TabIndex = 1;
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Dock = DockStyle.Fill;
            dgvBarang.Location = new Point(0, 44);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.Size = new Size(980, 267);
            dgvBarang.TabIndex = 14;
            dgvBarang.CellClick += dgvBarang_CellClick;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Dock = DockStyle.Top;
            txtCari.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            txtCari.Location = new Point(0, 18);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(980, 26);
            txtCari.TabIndex = 9;
            txtCari.Click += txtCari_TextChanged;
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
            label10.Size = new Size(114, 18);
            label10.TabIndex = 11;
            label10.Text = "Cari Barang :";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog1.Title = "Ekspor Data Barang";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog1.Title = "Impor Data Barang";
            // 
            // FormDataBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(982, 759);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDataBarang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDataBarang";
            Load += FormDataBarang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtKodeBarang;
        private TextBox txtNamaBarang;
        private NumericUpDown numStok;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnTambah;
        private Panel panel1;
        private DataGridView dgvBarang;
        private TextBox txtCari;
        private Label label10;
        private Button btnTutup;
        private ComboBox cmbSatuan;
        private Button btnImpor;
        private Button btnEkspor;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtKeterangan;
        private Label label9;
        private Label label11;
    }
}