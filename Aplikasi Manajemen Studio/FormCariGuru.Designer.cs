namespace Aplikasi_Manajemen_Studio
{
    partial class FormCariGuru
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
            dgvGuru = new DataGridView();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            panel2 = new Panel();
            btnPilih = new Button();
            btnBatal = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuru).BeginInit();
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
            panel1.TabIndex = 5;
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
            label10.Size = new Size(95, 18);
            label10.TabIndex = 11;
            label10.Text = "Cari Guru :";
            // 
            // dgvGuru
            // 
            dgvGuru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuru.Dock = DockStyle.Top;
            dgvGuru.Location = new Point(0, 46);
            dgvGuru.Name = "dgvGuru";
            dgvGuru.ReadOnly = true;
            dgvGuru.Size = new Size(906, 284);
            dgvGuru.TabIndex = 14;
            dgvGuru.CellDoubleClick += dgvGuru_CellDoubleClick;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.BackColor = Color.DarkKhaki;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirst.ForeColor = Color.White;
            btnFirst.Location = new Point(75, 21);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(110, 39);
            btnFirst.TabIndex = 6;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top;
            btnPrev.BackColor = Color.DarkKhaki;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(201, 21);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(110, 39);
            btnPrev.TabIndex = 7;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Top;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.Location = new Point(352, 25);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(213, 25);
            lblPageInfo.TabIndex = 8;
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
            btnNext.Location = new Point(603, 21);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(110, 39);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.BackColor = Color.DarkKhaki;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLast.ForeColor = Color.White;
            btnLast.Location = new Point(734, 21);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(110, 39);
            btnLast.TabIndex = 10;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
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
            panel2.TabIndex = 15;
            // 
            // btnPilih
            // 
            btnPilih.Anchor = AnchorStyles.Top;
            btnPilih.BackColor = Color.OliveDrab;
            btnPilih.Cursor = Cursors.Hand;
            btnPilih.FlatStyle = FlatStyle.Popup;
            btnPilih.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPilih.ForeColor = Color.White;
            btnPilih.Location = new Point(201, 421);
            btnPilih.Name = "btnPilih";
            btnPilih.Size = new Size(158, 49);
            btnPilih.TabIndex = 16;
            btnPilih.Text = "Pilih";
            btnPilih.UseVisualStyleBackColor = false;
            btnPilih.Click += btnPilih_Click;
            // 
            // btnBatal
            // 
            btnBatal.Anchor = AnchorStyles.Top;
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(555, 421);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(158, 49);
            btnBatal.TabIndex = 17;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormCariGuru
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 489);
            ControlBox = false;
            Controls.Add(btnBatal);
            Controls.Add(btnPilih);
            Controls.Add(panel2);
            Controls.Add(dgvGuru);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCariGuru";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCariGuru_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuru).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvGuru;
        private TextBox txtCari;
        private Label label10;
        private Button btnFirst;
        private Button btnPrev;
        private Label lblPageInfo;
        private Button btnNext;
        private Button btnLast;
        private Panel panel2;
        private Button btnPilih;
        private Button btnBatal;
    }
}