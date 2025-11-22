using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Studio
{
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        // Properti untuk mengubah warna latar belakang kartu
        public Color CardColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        // Properti untuk mengubah ikon kartu
        public Image CardIcon
        {
            get { return pictureBoxIcon.Image; }
            set { pictureBoxIcon.BackgroundImage = value; }
        }

        // Properti untuk mengubah nilai utama kartu
        public string CardValue
        {
            get { return labelValue.Text; }
            set { labelValue.Text = value; }
        }

        // Properti untuk mengubah judul kartu
        public string CardTitle
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
    }
}