namespace Aplikasi_Manajemen_Studio
{
    partial class FormDaftarPeminjaman
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
            dgvPending = new DataGridView();
            labelNamaUser = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvDetailPending = new DataGridView();
            label2 = new Label();
            btnTutup = new Button();
            btnRefresh = new Button();
            btnTolak = new Button();
            btnSetuju = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailPending).BeginInit();
            SuspendLayout();
            // 
            // dgvPending
            // 
            dgvPending.AllowUserToAddRows = false;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPending.Dock = DockStyle.Fill;
            dgvPending.Location = new Point(0, 25);
            dgvPending.Name = "dgvPending";
            dgvPending.Size = new Size(819, 385);
            dgvPending.TabIndex = 25;
            dgvPending.CellClick += dgvPending_CellClick;
            // 
            // labelNamaUser
            // 
            labelNamaUser.AutoSize = true;
            labelNamaUser.Dock = DockStyle.Top;
            labelNamaUser.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaUser.Location = new Point(0, 0);
            labelNamaUser.Name = "labelNamaUser";
            labelNamaUser.Size = new Size(261, 25);
            labelNamaUser.TabIndex = 24;
            labelNamaUser.Text = "Peminjaman Pending";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(dgvPending);
            panel1.Controls.Add(labelNamaUser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 410);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1585, 410);
            panel2.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(dgvDetailPending);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(819, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(766, 410);
            panel3.TabIndex = 28;
            // 
            // dgvDetailPending
            // 
            dgvDetailPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailPending.Dock = DockStyle.Fill;
            dgvDetailPending.Location = new Point(0, 25);
            dgvDetailPending.Name = "dgvDetailPending";
            dgvDetailPending.ReadOnly = true;
            dgvDetailPending.Size = new Size(766, 385);
            dgvDetailPending.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 24;
            label2.Text = "Detail Barang";
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.Maroon;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(1180, 452);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(246, 64);
            btnTutup.TabIndex = 37;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Goldenrod;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(857, 452);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(246, 64);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnTolak
            // 
            btnTolak.BackColor = Color.Firebrick;
            btnTolak.Cursor = Cursors.Hand;
            btnTolak.FlatStyle = FlatStyle.Popup;
            btnTolak.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTolak.ForeColor = Color.White;
            btnTolak.Location = new Point(536, 452);
            btnTolak.Name = "btnTolak";
            btnTolak.Size = new Size(246, 64);
            btnTolak.TabIndex = 35;
            btnTolak.Text = "Tolak";
            btnTolak.UseVisualStyleBackColor = false;
            btnTolak.Click += btnTolak_Click;
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.OliveDrab;
            btnSetuju.Cursor = Cursors.Hand;
            btnSetuju.FlatStyle = FlatStyle.Popup;
            btnSetuju.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(216, 452);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(246, 64);
            btnSetuju.TabIndex = 34;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            btnSetuju.Click += btnSetuju_Click;
            // 
            // FormDaftarPeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 559);
            Controls.Add(panel2);
            Controls.Add(btnTutup);
            Controls.Add(btnRefresh);
            Controls.Add(btnTolak);
            Controls.Add(btnSetuju);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDaftarPeminjaman";
            Text = "FormDaftarPeminjaman";
            Load += FormDaftarPeminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailPending).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPending;
        private Label labelNamaUser;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvDetailPending;
        private Label label2;
        private Button btnTutup;
        private Button btnRefresh;
        private Button btnTolak;
        private Button btnSetuju;
    }
}