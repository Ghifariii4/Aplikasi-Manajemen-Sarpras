namespace Aplikasi_Manajemen_Studio
{
    partial class FormDataPetugas
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
            cmbJabatan = new ComboBox();
            btnImpor = new Button();
            btnEkspor = new Button();
            label4 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            btnTutup = new Button();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnTambah = new Button();
            txtUsername = new TextBox();
            txtNamaLengkap = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvPetugas = new DataGridView();
            txtCari = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetugas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(cmbJabatan);
            groupBox1.Controls.Add(btnImpor);
            groupBox1.Controls.Add(btnEkspor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnBatal);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnUbah);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtNamaLengkap);
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
            groupBox1.Size = new Size(1012, 381);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data Petugas";
            // 
            // cmbJabatan
            // 
            cmbJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJabatan.FormattingEnabled = true;
            cmbJabatan.Location = new Point(665, 116);
            cmbJabatan.Name = "cmbJabatan";
            cmbJabatan.Size = new Size(221, 31);
            cmbJabatan.TabIndex = 18;
            // 
            // btnImpor
            // 
            btnImpor.BackColor = Color.DarkOrange;
            btnImpor.Cursor = Cursors.Hand;
            btnImpor.FlatStyle = FlatStyle.Popup;
            btnImpor.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImpor.ForeColor = Color.White;
            btnImpor.Location = new Point(24, 311);
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
            btnEkspor.Location = new Point(213, 311);
            btnEkspor.Name = "btnEkspor";
            btnEkspor.Size = new Size(153, 43);
            btnEkspor.TabIndex = 17;
            btnEkspor.Text = "Ekspor Data";
            btnEkspor.UseVisualStyleBackColor = false;
            btnEkspor.Click += btnEkspor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label4.Location = new Point(627, 119);
            label4.Name = "label4";
            label4.Size = new Size(18, 23);
            label4.TabIndex = 11;
            label4.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label8.Location = new Point(511, 119);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 10;
            label8.Text = "Jabatan";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(665, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(221, 31);
            txtPassword.TabIndex = 3;
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
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtUsername.Location = new Point(248, 116);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            txtNamaLengkap.Location = new Point(248, 56);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(221, 31);
            txtNamaLengkap.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label7.Location = new Point(627, 59);
            label7.Name = "label7";
            label7.Size = new Size(18, 23);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label6.Location = new Point(197, 119);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 6;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label5.Location = new Point(197, 59);
            label5.Name = "label5";
            label5.Size = new Size(18, 23);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label3.Location = new Point(511, 59);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 119);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 1;
            label1.Text = "Nama Lengkap";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvPetugas);
            panel1.Controls.Add(txtCari);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 206);
            panel1.TabIndex = 4;
            // 
            // dgvPetugas
            // 
            dgvPetugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetugas.Dock = DockStyle.Fill;
            dgvPetugas.Location = new Point(0, 44);
            dgvPetugas.Name = "dgvPetugas";
            dgvPetugas.ReadOnly = true;
            dgvPetugas.Size = new Size(1010, 160);
            dgvPetugas.TabIndex = 14;
            dgvPetugas.CellClick += dgvPetugas_CellClick;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Dock = DockStyle.Top;
            txtCari.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            txtCari.Location = new Point(0, 18);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(1010, 26);
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
            label10.Size = new Size(123, 18);
            label10.TabIndex = 11;
            label10.Text = "Cari Petugas :";
            // 
            // FormDataPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 587);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDataPetugas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormDataPetugas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Button btnTutup;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnTambah;
        private TextBox txtUsername;
        private TextBox txtNamaLengkap;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
        private Panel panel1;
        private DataGridView dgvPetugas;
        private TextBox txtCari;
        private Label label10;
        private Button btnImpor;
        private Button btnEkspor;
        private ComboBox cmbJabatan;
    }
}