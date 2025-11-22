namespace Aplikasi_Manajemen_Studio
{
    partial class FormDataKelas
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
            label10 = new Label();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnTambah = new Button();
            txtTingkat = new TextBox();
            txtNamaKelas = new TextBox();
            dgvKelas = new DataGridView();
            panel1 = new Panel();
            txtCari = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnImpor = new Button();
            btnEkspor = new Button();
            btnTutup = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKelas).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            label10.Size = new Size(101, 18);
            label10.TabIndex = 11;
            label10.Text = "Cari Kelas :";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.DodgerBlue;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(611, 205);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(153, 45);
            btnBatal.TabIndex = 6;
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
            btnHapus.Location = new Point(416, 205);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(153, 45);
            btnHapus.TabIndex = 5;
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
            btnUbah.Location = new Point(219, 205);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(153, 45);
            btnUbah.TabIndex = 4;
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
            btnTambah.Location = new Point(30, 205);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(153, 45);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtTingkat
            // 
            txtTingkat.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtTingkat.Location = new Point(219, 126);
            txtTingkat.Name = "txtTingkat";
            txtTingkat.Size = new Size(221, 31);
            txtTingkat.TabIndex = 2;
            // 
            // txtNamaKelas
            // 
            txtNamaKelas.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtNamaKelas.Location = new Point(219, 66);
            txtNamaKelas.Name = "txtNamaKelas";
            txtNamaKelas.Size = new Size(221, 31);
            txtNamaKelas.TabIndex = 1;
            // 
            // dgvKelas
            // 
            dgvKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelas.Dock = DockStyle.Fill;
            dgvKelas.Location = new Point(0, 44);
            dgvKelas.Name = "dgvKelas";
            dgvKelas.ReadOnly = true;
            dgvKelas.Size = new Size(980, 142);
            dgvKelas.TabIndex = 14;
            dgvKelas.CellClick += dgvKelas_CellClick;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvKelas);
            panel1.Controls.Add(txtCari);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 188);
            panel1.TabIndex = 3;
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
            txtCari.TabIndex = 7;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label5.Location = new Point(180, 69);
            label5.Name = "label5";
            label5.Size = new Size(18, 23);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label2.Location = new Point(30, 129);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 2;
            label2.Text = "Tingkat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(30, 69);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 1;
            label1.Text = "Nama Kelas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label6.Location = new Point(180, 129);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 6;
            label6.Text = ":";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnImpor);
            groupBox1.Controls.Add(btnEkspor);
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnBatal);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnUbah);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(txtTingkat);
            groupBox1.Controls.Add(txtNamaKelas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 345);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data Kelas";
            // 
            // btnImpor
            // 
            btnImpor.BackColor = Color.DarkOrange;
            btnImpor.Cursor = Cursors.Hand;
            btnImpor.FlatStyle = FlatStyle.Popup;
            btnImpor.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImpor.ForeColor = Color.White;
            btnImpor.Location = new Point(30, 279);
            btnImpor.Name = "btnImpor";
            btnImpor.Size = new Size(153, 43);
            btnImpor.TabIndex = 18;
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
            btnEkspor.Location = new Point(219, 279);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(153, 43);
            btnEkspor.TabIndex = 19;
            btnEkspor.Text = "Ekspor Data";
            btnEkspor.UseVisualStyleBackColor = false;
            btnEkspor.Click += btnEkspor_Click;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Maroon;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(805, 205);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(153, 45);
            btnTutup.TabIndex = 9;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnExit_Click;
            // 
            // FormDataKelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDataKelas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDataKelas";
            Load += FormDataKelas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKelas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnTambah;
        private TextBox txtTingkat;
        private TextBox txtNamaKelas;
        private DataGridView dgvKelas;
        private Panel panel1;
        private TextBox txtCari;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnImpor;
        private Button btnEkspor;
    }
}