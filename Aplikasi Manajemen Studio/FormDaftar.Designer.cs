namespace Aplikasi_Manajemen_Studio
{
    partial class FormDaftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftar));
            panelTop = new Panel();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnBatal = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            labelNamaUser = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            txtNamaLengkap = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            checkBox1 = new CheckBox();
            txtKonfirmasiPassword = new TextBox();
            cmbJabatan = new ComboBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnExit);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(618, 50);
            panelTop.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 15);
            label1.Name = "label1";
            label1.Size = new Size(198, 18);
            label1.TabIndex = 0;
            label1.Text = "Daftar Petugas - AMS";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(551, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnBatal_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(310, 522);
            label5.Name = "label5";
            label5.Size = new Size(14, 18);
            label5.TabIndex = 28;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(310, 475);
            label4.Name = "label4";
            label4.Size = new Size(14, 18);
            label4.TabIndex = 27;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 522);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 26;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 475);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 25;
            label2.Text = "USERNAME";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(317, 686);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 42);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "DAFTAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnDaftar_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Maroon;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(74, 686);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(224, 42);
            btnBatal.TabIndex = 22;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(344, 551);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(154, 18);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Tampilkan Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(344, 519);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(187, 26);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(344, 472);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 26);
            txtUsername.TabIndex = 17;
            // 
            // labelNamaUser
            // 
            labelNamaUser.AutoSize = true;
            labelNamaUser.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaUser.Location = new Point(205, 293);
            labelNamaUser.Name = "labelNamaUser";
            labelNamaUser.Size = new Size(220, 25);
            labelNamaUser.TabIndex = 23;
            labelNamaUser.Text = "DAFTAR PETUGAS";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(220, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 181);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(310, 384);
            label8.Name = "label8";
            label8.Size = new Size(14, 18);
            label8.TabIndex = 34;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(75, 384);
            label9.Name = "label9";
            label9.Size = new Size(142, 18);
            label9.TabIndex = 33;
            label9.Text = "NAMA LENGKAP";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaLengkap.Location = new Point(344, 381);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(187, 26);
            txtNamaLengkap.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(310, 429);
            label10.Name = "label10";
            label10.Size = new Size(14, 18);
            label10.TabIndex = 37;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(75, 429);
            label11.Name = "label11";
            label11.Size = new Size(142, 18);
            label11.TabIndex = 36;
            label11.Text = "NAMA LENGKAP";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(310, 578);
            label12.Name = "label12";
            label12.Size = new Size(14, 18);
            label12.TabIndex = 41;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(75, 578);
            label13.Name = "label13";
            label13.Size = new Size(223, 18);
            label13.TabIndex = 40;
            label13.Text = "KONFIRMASI PASSWORD";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(344, 607);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 18);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Tampilkan Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKonfirmasiPassword.Location = new Point(344, 575);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.PasswordChar = '*';
            txtKonfirmasiPassword.Size = new Size(187, 26);
            txtKonfirmasiPassword.TabIndex = 38;
            // 
            // cmbJabatan
            // 
            cmbJabatan.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbJabatan.FormattingEnabled = true;
            cmbJabatan.Location = new Point(344, 429);
            cmbJabatan.Name = "cmbJabatan";
            cmbJabatan.Size = new Size(187, 26);
            cmbJabatan.TabIndex = 42;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(618, 793);
            Controls.Add(cmbJabatan);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(checkBox1);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtNamaLengkap);
            Controls.Add(panelTop);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(btnBatal);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelNamaUser);
            Controls.Add(pictureBox2);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDaftar";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDaftar";
            Load += FormDaftar_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label label1;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private Button btnBatal;
        private CheckBox chkShowPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label labelNamaUser;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private TextBox txtNamaLengkap;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private CheckBox checkBox1;
        private TextBox txtKonfirmasiPassword;
        private ComboBox cmbJabatan;
    }
}