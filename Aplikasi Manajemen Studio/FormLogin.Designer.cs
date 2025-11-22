namespace Aplikasi_Manajemen_Studio
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelTop = new Panel();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelNamaUser = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnBatal = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            linkDaftar = new LinkLabel();
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
            panelTop.Size = new Size(518, 50);
            panelTop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 15);
            label1.Name = "label1";
            label1.Size = new Size(188, 18);
            label1.TabIndex = 0;
            label1.Text = "Login Petugas - AMS";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(451, 0);
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(157, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 181);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // labelNamaUser
            // 
            labelNamaUser.AutoSize = true;
            labelNamaUser.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaUser.Location = new Point(150, 271);
            labelNamaUser.Name = "labelNamaUser";
            labelNamaUser.Size = new Size(204, 25);
            labelNamaUser.TabIndex = 4;
            labelNamaUser.Text = "LOGIN PETUGAS";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(234, 342);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 26);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(234, 394);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(187, 26);
            txtPassword.TabIndex = 2;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(234, 426);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(156, 20);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Tampilkan Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.Click += chkShowPassword_CheckedChanged;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Maroon;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(84, 512);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(159, 42);
            btnBatal.TabIndex = 4;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(262, 512);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 345);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 13;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 397);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 14;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 345);
            label4.Name = "label4";
            label4.Size = new Size(14, 18);
            label4.TabIndex = 15;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(200, 397);
            label5.Name = "label5";
            label5.Size = new Size(14, 18);
            label5.TabIndex = 16;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 461);
            label6.Name = "label6";
            label6.Size = new Size(231, 18);
            label6.TabIndex = 17;
            label6.Text = "Belum Memiliki Akun Petugas?";
            label6.Click += label6_Click;
            // 
            // linkDaftar
            // 
            linkDaftar.AutoSize = true;
            linkDaftar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkDaftar.Location = new Point(338, 461);
            linkDaftar.Name = "linkDaftar";
            linkDaftar.Size = new Size(54, 18);
            linkDaftar.TabIndex = 18;
            linkDaftar.TabStop = true;
            linkDaftar.Text = "Daftar";
            linkDaftar.LinkClicked += linkDaftar_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(518, 597);
            Controls.Add(linkDaftar);
            Controls.Add(label6);
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
            Controls.Add(panelTop);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLogin";
            Load += FormLogin_Load;
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelNamaUser;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnBatal;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel linkDaftar;
    }
}