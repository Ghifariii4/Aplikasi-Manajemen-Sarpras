namespace Aplikasi_Manajemen_Studio
{
    partial class FormCariSiswa
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
            panel1 = new Panel();
            txtCari = new TextBox();
            label10 = new Label();
            dgvSiswa = new DataGridView();
            btnBatal = new Button();
            btnPilih = new Button();
            panel2 = new Panel();
            btnPrev = new Button();
            btnFirst = new Button();
            btnLast = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCari);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 46);
            panel1.TabIndex = 18;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Dock = DockStyle.Top;
            txtCari.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            txtCari.Location = new Point(0, 18);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(904, 26);
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
            // dgvSiswa
            // 
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Dock = DockStyle.Top;
            dgvSiswa.Location = new Point(0, 46);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.ReadOnly = true;
            dgvSiswa.Size = new Size(906, 284);
            dgvSiswa.TabIndex = 19;
            dgvSiswa.CellDoubleClick += dgvSiswa_CellDoubleClick;
            // 
            // btnBatal
            // 
            btnBatal.Anchor = AnchorStyles.Top;
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(549, 420);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(158, 49);
            btnBatal.TabIndex = 22;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnPilih
            // 
            btnPilih.Anchor = AnchorStyles.Top;
            btnPilih.BackColor = Color.OliveDrab;
            btnPilih.Cursor = Cursors.Hand;
            btnPilih.FlatStyle = FlatStyle.Popup;
            btnPilih.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPilih.ForeColor = Color.White;
            btnPilih.Location = new Point(195, 420);
            btnPilih.Name = "btnPilih";
            btnPilih.Size = new Size(158, 49);
            btnPilih.TabIndex = 21;
            btnPilih.Text = "Pilih";
            btnPilih.UseVisualStyleBackColor = false;
            btnPilih.Click += btnPilih_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnNext);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 72);
            panel2.TabIndex = 20;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top;
            btnPrev.BackColor = Color.DarkKhaki;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(195, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(110, 39);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.BackColor = Color.DarkKhaki;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirst.ForeColor = Color.White;
            btnFirst.Location = new Point(69, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(110, 39);
            btnFirst.TabIndex = 11;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.BackColor = Color.DarkKhaki;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLast.ForeColor = Color.White;
            btnLast.Location = new Point(728, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(110, 39);
            btnLast.TabIndex = 15;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Top;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.Location = new Point(346, 21);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(213, 25);
            lblPageInfo.TabIndex = 13;
            lblPageInfo.Text = "Halaman 1 dari 1";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.BackColor = Color.DarkKhaki;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(597, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(110, 39);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FormCariSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 489);
            Controls.Add(panel2);
            Controls.Add(dgvSiswa);
            Controls.Add(btnBatal);
            Controls.Add(btnPilih);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCariSiswa";
            Load += FormCariSiswa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtCari;
        private Label label10;
        private DataGridView dgvSiswa;
        private Button btnBatal;
        private Button btnPilih;
        private Panel panel2;
        private Button btnPrev;
        private Button btnFirst;
        private Button btnLast;
        private Label lblPageInfo;
        private Button btnNext;
    }
}