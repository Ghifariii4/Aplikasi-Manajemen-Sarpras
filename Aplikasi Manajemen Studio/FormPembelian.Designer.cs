namespace Aplikasi_Manajemen_Studio
{
    partial class FormPembelian
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
            panelTop = new Panel();
            label1 = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            dtpTanggalBeli = new DateTimePicker();
            txtPemasok = new TextBox();
            txtNoFaktur = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            numJumlah = new NumericUpDown();
            cmbBarang = new ComboBox();
            txtHargaSatuan = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnSimpanPembelian = new Button();
            btnBatal = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label15 = new Label();
            txtCari = new TextBox();
            label14 = new Label();
            panel5 = new Panel();
            dgvPembelian = new DataGridView();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1009, 50);
            panelTop.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(205, 18);
            label1.TabIndex = 0;
            label1.Text = "Form Pembelian - AMS";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(919, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "Tutup";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(dtpTanggalBeli);
            panel1.Controls.Add(txtPemasok);
            panel1.Controls.Add(txtNoFaktur);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 146);
            panel1.TabIndex = 5;
            // 
            // dtpTanggalBeli
            // 
            dtpTanggalBeli.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTanggalBeli.Location = new Point(656, 35);
            dtpTanggalBeli.Name = "dtpTanggalBeli";
            dtpTanggalBeli.Size = new Size(330, 27);
            dtpTanggalBeli.TabIndex = 8;
            dtpTanggalBeli.ValueChanged += dtpTanggalBeli_ValueChanged;
            // 
            // txtPemasok
            // 
            txtPemasok.BackColor = Color.SkyBlue;
            txtPemasok.Cursor = Cursors.IBeam;
            txtPemasok.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPemasok.Location = new Point(190, 83);
            txtPemasok.Name = "txtPemasok";
            txtPemasok.Size = new Size(243, 27);
            txtPemasok.TabIndex = 7;
            // 
            // txtNoFaktur
            // 
            txtNoFaktur.BackColor = Color.WhiteSmoke;
            txtNoFaktur.Cursor = Cursors.IBeam;
            txtNoFaktur.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNoFaktur.Location = new Point(190, 35);
            txtNoFaktur.Name = "txtNoFaktur";
            txtNoFaktur.Size = new Size(243, 27);
            txtNoFaktur.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(636, 38);
            label7.Name = "label7";
            label7.Size = new Size(14, 18);
            label7.TabIndex = 5;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 86);
            label6.Name = "label6";
            label6.Size = new Size(14, 18);
            label6.TabIndex = 4;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(167, 38);
            label5.Name = "label5";
            label5.Size = new Size(14, 18);
            label5.TabIndex = 3;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(498, 38);
            label4.Name = "label4";
            label4.Size = new Size(115, 18);
            label4.TabIndex = 2;
            label4.Text = "Tanggal Beli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 1;
            label3.Text = "Pemasok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 0;
            label2.Text = "Nomor Faktur";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(numJumlah);
            panel2.Controls.Add(cmbBarang);
            panel2.Controls.Add(txtHargaSatuan);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 151);
            panel2.TabIndex = 6;
            // 
            // numJumlah
            // 
            numJumlah.BackColor = Color.SkyBlue;
            numJumlah.Cursor = Cursors.IBeam;
            numJumlah.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numJumlah.Location = new Point(190, 84);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(243, 27);
            numJumlah.TabIndex = 8;
            // 
            // cmbBarang
            // 
            cmbBarang.BackColor = Color.SkyBlue;
            cmbBarang.Cursor = Cursors.IBeam;
            cmbBarang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarang.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBarang.FormattingEnabled = true;
            cmbBarang.Location = new Point(190, 35);
            cmbBarang.Name = "cmbBarang";
            cmbBarang.Size = new Size(243, 26);
            cmbBarang.TabIndex = 7;
            cmbBarang.SelectedIndexChanged += cmbBarang_SelectedIndexChanged;
            // 
            // txtHargaSatuan
            // 
            txtHargaSatuan.BackColor = Color.SkyBlue;
            txtHargaSatuan.Cursor = Cursors.IBeam;
            txtHargaSatuan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHargaSatuan.Location = new Point(656, 35);
            txtHargaSatuan.Name = "txtHargaSatuan";
            txtHargaSatuan.Size = new Size(330, 27);
            txtHargaSatuan.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(636, 38);
            label8.Name = "label8";
            label8.Size = new Size(14, 18);
            label8.TabIndex = 5;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(167, 86);
            label9.Name = "label9";
            label9.Size = new Size(14, 18);
            label9.TabIndex = 4;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(167, 38);
            label10.Name = "label10";
            label10.Size = new Size(14, 18);
            label10.TabIndex = 3;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(498, 38);
            label11.Name = "label11";
            label11.Size = new Size(129, 18);
            label11.TabIndex = 2;
            label11.Text = "Harga Satuan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 86);
            label12.Name = "label12";
            label12.Size = new Size(70, 18);
            label12.TabIndex = 1;
            label12.Text = "Jumlah";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 38);
            label13.Name = "label13";
            label13.Size = new Size(124, 18);
            label13.TabIndex = 0;
            label13.Text = "Barang Dibeli";
            // 
            // btnSimpanPembelian
            // 
            btnSimpanPembelian.BackColor = Color.OliveDrab;
            btnSimpanPembelian.Cursor = Cursors.Hand;
            btnSimpanPembelian.FlatStyle = FlatStyle.Popup;
            btnSimpanPembelian.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanPembelian.ForeColor = Color.White;
            btnSimpanPembelian.Location = new Point(190, 21);
            btnSimpanPembelian.Name = "btnSimpanPembelian";
            btnSimpanPembelian.Size = new Size(243, 51);
            btnSimpanPembelian.TabIndex = 9;
            btnSimpanPembelian.Text = "Simpan Pembelian";
            btnSimpanPembelian.UseVisualStyleBackColor = false;
            btnSimpanPembelian.Click += btnSimpanPembelian_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(546, 21);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(243, 51);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(btnBatal);
            panel3.Controls.Add(btnSimpanPembelian);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 347);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 95);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FloralWhite;
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtCari);
            panel4.Controls.Add(label14);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 442);
            panel4.Name = "panel4";
            panel4.Size = new Size(1009, 112);
            panel4.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(3, 17);
            label15.Name = "label15";
            label15.Size = new Size(302, 23);
            label15.TabIndex = 14;
            label15.Text = "Riwayat Pembelian Barang";
            // 
            // txtCari
            // 
            txtCari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            txtCari.Location = new Point(3, 82);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(1001, 26);
            txtCari.TabIndex = 12;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(3, 64);
            label14.Name = "label14";
            label14.Size = new Size(123, 18);
            label14.TabIndex = 13;
            label14.Text = "Cari Riwayat :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FloralWhite;
            panel5.Controls.Add(dgvPembelian);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 554);
            panel5.Name = "panel5";
            panel5.Size = new Size(1009, 267);
            panel5.TabIndex = 13;
            // 
            // dgvPembelian
            // 
            dgvPembelian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPembelian.Dock = DockStyle.Fill;
            dgvPembelian.Location = new Point(0, 0);
            dgvPembelian.Name = "dgvPembelian";
            dgvPembelian.ReadOnly = true;
            dgvPembelian.Size = new Size(1009, 267);
            dgvPembelian.TabIndex = 0;
            // 
            // FormPembelian
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 821);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPembelian";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormPembelian_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label1;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private DateTimePicker dtpTanggalBeli;
        private TextBox txtPemasok;
        private TextBox txtNoFaktur;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private TextBox txtHargaSatuan;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cmbBarang;
        private NumericUpDown numJumlah;
        private Button btnSimpanPembelian;
        private Button btnBatal;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtCari;
        private Label label14;
        private Label label15;
        private Panel panel5;
        private DataGridView dgvPembelian;
    }
}