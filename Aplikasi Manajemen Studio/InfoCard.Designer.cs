namespace Aplikasi_Manajemen_Studio
{
    partial class InfoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxIcon = new PictureBox();
            labelValue = new Label();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxIcon.Location = new Point(28, 26);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(60, 60);
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValue.ForeColor = Color.White;
            labelValue.Location = new Point(109, 19);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(38, 45);
            labelValue.TabIndex = 1;
            labelValue.Text = "0";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(109, 69);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(79, 17);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Judul Kartu";
            // 
            // InfoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            Controls.Add(labelTitle);
            Controls.Add(labelValue);
            Controls.Add(pictureBoxIcon);
            ForeColor = Color.White;
            Name = "InfoCard";
            Size = new Size(280, 120);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIcon;
        private Label labelValue;
        private Label labelTitle;
    }
}
