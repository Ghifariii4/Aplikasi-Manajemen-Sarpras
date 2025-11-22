namespace Aplikasi_Manajemen_Studio
{
    partial class FormLaporanKerusakan
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
            btnTutup = new Button();
            btnBatal = new Button();
            label22 = new Label();
            label23 = new Label();
            txtKeterangan = new TextBox();
            btnSimpan = new Button();
            cmbBarang = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            numJumlah = new NumericUpDown();
            dgvRiwayatKerusakan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatKerusakan).BeginInit();
            SuspendLayout();
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.DarkOrange;
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatStyle = FlatStyle.Popup;
            btnTutup.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(544, 356);
            btnTutup.Margin = new Padding(4);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(195, 53);
            btnTutup.TabIndex = 40;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatStyle = FlatStyle.Popup;
            btnBatal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(284, 356);
            btnBatal.Margin = new Padding(4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(195, 53);
            btnBatal.TabIndex = 39;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(349, 117);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(18, 23);
            label22.TabIndex = 38;
            label22.Text = ":";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(48, 117);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(178, 23);
            label23.TabIndex = 37;
            label23.Text = "JUMLAH RUSAK";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(373, 177);
            txtKeterangan.Margin = new Padding(4);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(366, 135);
            txtKeterangan.TabIndex = 36;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.OliveDrab;
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatStyle = FlatStyle.Popup;
            btnSimpan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(25, 356);
            btnSimpan.Margin = new Padding(4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(195, 53);
            btnSimpan.TabIndex = 35;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbBarang
            // 
            cmbBarang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarang.FormattingEnabled = true;
            cmbBarang.Items.AddRange(new object[] { "Semua", "Dipinjam", "Sudah Kembali" });
            cmbBarang.Location = new Point(373, 51);
            cmbBarang.Margin = new Padding(4);
            cmbBarang.Name = "cmbBarang";
            cmbBarang.Size = new Size(366, 31);
            cmbBarang.TabIndex = 34;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(352, 180);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(18, 23);
            label18.TabIndex = 30;
            label18.Text = ":";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(349, 54);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(18, 23);
            label19.TabIndex = 29;
            label19.Text = ":";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(48, 180);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(296, 23);
            label20.TabIndex = 28;
            label20.Text = "KETERANGAN KERUSAKAN";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(48, 54);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 27;
            label21.Text = "BARANG";
            // 
            // numJumlah
            // 
            numJumlah.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numJumlah.Location = new Point(373, 115);
            numJumlah.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(366, 31);
            numJumlah.TabIndex = 41;
            // 
            // dgvRiwayatKerusakan
            // 
            dgvRiwayatKerusakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatKerusakan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRiwayatKerusakan.BorderStyle = BorderStyle.None;
            dgvRiwayatKerusakan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatKerusakan.Dock = DockStyle.Bottom;
            dgvRiwayatKerusakan.Location = new Point(0, 455);
            dgvRiwayatKerusakan.Name = "dgvRiwayatKerusakan";
            dgvRiwayatKerusakan.ReadOnly = true;
            dgvRiwayatKerusakan.Size = new Size(808, 368);
            dgvRiwayatKerusakan.TabIndex = 42;
            // 
            // FormLaporanKerusakan
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(808, 823);
            Controls.Add(dgvRiwayatKerusakan);
            Controls.Add(numJumlah);
            Controls.Add(btnTutup);
            Controls.Add(btnBatal);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(txtKeterangan);
            Controls.Add(btnSimpan);
            Controls.Add(cmbBarang);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormLaporanKerusakan";
            Text = "FormLaporanKerusakan";
            Load += FormLaporanKerusakan_Load;
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatKerusakan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTutup;
        private Button btnBatal;
        private Label label22;
        private Label label23;
        private TextBox txtKeterangan;
        private Button btnSimpan;
        private ComboBox cmbBarang;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private NumericUpDown numJumlah;
        private DataGridView dgvRiwayatKerusakan;
    }
}