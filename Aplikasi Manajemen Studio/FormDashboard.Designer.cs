namespace Aplikasi_Manajemen_Studio
{
    partial class FormDashboard
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
            labelWelcomeUser = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanelCards = new FlowLayoutPanel();
            panelQuickActionsNotifications = new Panel();
            labelCriticalStockWarning = new Label();
            labelNotification = new Label();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnBuatPermintaanBaru = new Button();
            btnLihatPermintaanPending = new Button();
            btnLihatStokKritis = new Button();
            btnRefreshDashboard = new Button();
            labelQuickActionsTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelQuickActionsNotifications.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcomeUser
            // 
            labelWelcomeUser.AutoSize = true;
            labelWelcomeUser.BackColor = Color.Goldenrod;
            labelWelcomeUser.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeUser.Location = new Point(77, 82);
            labelWelcomeUser.Name = "labelWelcomeUser";
            labelWelcomeUser.Size = new Size(430, 50);
            labelWelcomeUser.TabIndex = 5;
            labelWelcomeUser.Text = "Selamat Datang, Admin!";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Goldenrod;
            pictureBox1.BackgroundImage = Properties.Resources._275356;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1302, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 155);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.Anchor = AnchorStyles.Top;
            flowLayoutPanelCards.Location = new Point(221, 268);
            flowLayoutPanelCards.Margin = new Padding(40, 0, 0, 0);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Padding = new Padding(20);
            flowLayoutPanelCards.Size = new Size(1190, 120);
            flowLayoutPanelCards.TabIndex = 9;
            // 
            // panelQuickActionsNotifications
            // 
            panelQuickActionsNotifications.Anchor = AnchorStyles.Top;
            panelQuickActionsNotifications.Controls.Add(labelCriticalStockWarning);
            panelQuickActionsNotifications.Controls.Add(labelNotification);
            panelQuickActionsNotifications.Controls.Add(flowLayoutPanelButtons);
            panelQuickActionsNotifications.Controls.Add(btnRefreshDashboard);
            panelQuickActionsNotifications.Controls.Add(labelQuickActionsTitle);
            panelQuickActionsNotifications.Location = new Point(221, 415);
            panelQuickActionsNotifications.Name = "panelQuickActionsNotifications";
            panelQuickActionsNotifications.Padding = new Padding(10);
            panelQuickActionsNotifications.Size = new Size(1190, 247);
            panelQuickActionsNotifications.TabIndex = 10;
            // 
            // labelCriticalStockWarning
            // 
            labelCriticalStockWarning.AutoSize = true;
            labelCriticalStockWarning.BackColor = Color.Transparent;
            labelCriticalStockWarning.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCriticalStockWarning.ForeColor = Color.Red;
            labelCriticalStockWarning.Location = new Point(18, 182);
            labelCriticalStockWarning.Margin = new Padding(3, 0, 3, 10);
            labelCriticalStockWarning.Name = "labelCriticalStockWarning";
            labelCriticalStockWarning.Size = new Size(250, 20);
            labelCriticalStockWarning.TabIndex = 12;
            labelCriticalStockWarning.Text = "Ada [X] barang dengan stok kritis!";
            labelCriticalStockWarning.Visible = false;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.BackColor = Color.Transparent;
            labelNotification.Dock = DockStyle.Bottom;
            labelNotification.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNotification.ForeColor = Color.DimGray;
            labelNotification.Location = new Point(10, 212);
            labelNotification.Margin = new Padding(3, 0, 3, 10);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(307, 25);
            labelNotification.TabIndex = 11;
            labelNotification.Text = "Tidak ada notifikasi penting saat ini.";
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Anchor = AnchorStyles.Top;
            flowLayoutPanelButtons.Controls.Add(btnBuatPermintaanBaru);
            flowLayoutPanelButtons.Controls.Add(btnLihatPermintaanPending);
            flowLayoutPanelButtons.Controls.Add(btnLihatStokKritis);
            flowLayoutPanelButtons.Location = new Point(10, 35);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(5);
            flowLayoutPanelButtons.Size = new Size(1168, 88);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // btnBuatPermintaanBaru
            // 
            btnBuatPermintaanBaru.BackColor = Color.DodgerBlue;
            btnBuatPermintaanBaru.Cursor = Cursors.Hand;
            btnBuatPermintaanBaru.FlatStyle = FlatStyle.Popup;
            btnBuatPermintaanBaru.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBuatPermintaanBaru.ForeColor = Color.White;
            btnBuatPermintaanBaru.Location = new Point(8, 8);
            btnBuatPermintaanBaru.Name = "btnBuatPermintaanBaru";
            btnBuatPermintaanBaru.Padding = new Padding(5);
            btnBuatPermintaanBaru.Size = new Size(380, 64);
            btnBuatPermintaanBaru.TabIndex = 1;
            btnBuatPermintaanBaru.Text = "+ Buat Permintaan Baru";
            btnBuatPermintaanBaru.UseVisualStyleBackColor = false;
            btnBuatPermintaanBaru.Click += btnBuatPermintaanBaru_Click;
            // 
            // btnLihatPermintaanPending
            // 
            btnLihatPermintaanPending.BackColor = Color.OrangeRed;
            btnLihatPermintaanPending.Cursor = Cursors.Hand;
            btnLihatPermintaanPending.FlatStyle = FlatStyle.Popup;
            btnLihatPermintaanPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLihatPermintaanPending.ForeColor = Color.White;
            btnLihatPermintaanPending.Location = new Point(394, 8);
            btnLihatPermintaanPending.Name = "btnLihatPermintaanPending";
            btnLihatPermintaanPending.Padding = new Padding(5);
            btnLihatPermintaanPending.Size = new Size(380, 64);
            btnLihatPermintaanPending.TabIndex = 2;
            btnLihatPermintaanPending.Text = "Lihat Laporan Aktivitas";
            btnLihatPermintaanPending.UseVisualStyleBackColor = false;
            btnLihatPermintaanPending.Click += btnLihatPermintaanPending_Click;
            // 
            // btnLihatStokKritis
            // 
            btnLihatStokKritis.BackColor = Color.Firebrick;
            btnLihatStokKritis.Cursor = Cursors.Hand;
            btnLihatStokKritis.FlatStyle = FlatStyle.Popup;
            btnLihatStokKritis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLihatStokKritis.ForeColor = Color.White;
            btnLihatStokKritis.Location = new Point(780, 8);
            btnLihatStokKritis.Name = "btnLihatStokKritis";
            btnLihatStokKritis.Padding = new Padding(5);
            btnLihatStokKritis.Size = new Size(380, 64);
            btnLihatStokKritis.TabIndex = 3;
            btnLihatStokKritis.Text = "Lihat Barang Stok Kritis";
            btnLihatStokKritis.UseVisualStyleBackColor = false;
            btnLihatStokKritis.Click += btnLihatStokKritis_Click;
            // 
            // btnRefreshDashboard
            // 
            btnRefreshDashboard.Anchor = AnchorStyles.Top;
            btnRefreshDashboard.BackColor = Color.OliveDrab;
            btnRefreshDashboard.Cursor = Cursors.Hand;
            btnRefreshDashboard.FlatStyle = FlatStyle.Popup;
            btnRefreshDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRefreshDashboard.ForeColor = Color.White;
            btnRefreshDashboard.Location = new Point(493, 126);
            btnRefreshDashboard.Name = "btnRefreshDashboard";
            btnRefreshDashboard.Padding = new Padding(5);
            btnRefreshDashboard.Size = new Size(207, 50);
            btnRefreshDashboard.TabIndex = 4;
            btnRefreshDashboard.Text = "Refresh Dashboard";
            btnRefreshDashboard.UseVisualStyleBackColor = false;
            btnRefreshDashboard.Click += btnRefreshDashboard_Click;
            // 
            // labelQuickActionsTitle
            // 
            labelQuickActionsTitle.AutoSize = true;
            labelQuickActionsTitle.Dock = DockStyle.Top;
            labelQuickActionsTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuickActionsTitle.Location = new Point(10, 10);
            labelQuickActionsTitle.Margin = new Padding(3, 0, 3, 10);
            labelQuickActionsTitle.Name = "labelQuickActionsTitle";
            labelQuickActionsTitle.Size = new Size(308, 25);
            labelQuickActionsTitle.TabIndex = 0;
            labelQuickActionsTitle.Text = "Aksi Cepat dan Notifikasi Penting";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Location = new Point(45, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 196);
            panel1.TabIndex = 11;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1620, 1000);
            ControlBox = false;
            Controls.Add(panelQuickActionsNotifications);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(pictureBox1);
            Controls.Add(labelWelcomeUser);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelQuickActionsNotifications.ResumeLayout(false);
            panelQuickActionsNotifications.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BetterRoundedPanel betterRoundedPanel1;
        private Label labelWelcomeUser;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanelCards;
        private Panel panelQuickActionsNotifications;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Label labelQuickActionsTitle;
        private Button btnBuatPermintaanBaru;
        private Button btnLihatPermintaanPending;
        private Button btnLihatStokKritis;
        private Label labelCriticalStockWarning;
        private Label labelNotification;
        private Button btnRefreshDashboard;
        private Panel panel1;
    }
}