using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Aplikasi_Manajemen_Studio
{
    [DefaultEvent("Click")]
    public class BetterRoundedPanel : UserControl
    {
        private int _cornerRadius = 20;
        private Color _borderColor = Color.LightGray;
        private int _borderThickness = 1;
        private bool _dropShadow = true;
        private Color _shadowColor = Color.FromArgb(50, 0, 0, 0); // Semi-transparent black
        private int _shadowDepth = 5; // How far the shadow extends
        private int _shadowBlur = 10; // Blur radius of the shadow

        public BetterRoundedPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = SystemColors.ControlLightLight;
        }

        // --- Properti Baru (Tidak Berubah) ---
        [Category("Rounded Panel")]
        [Description("Radius sudut untuk panel.")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                if (value < 0) value = 0;
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Warna border panel.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Ketebalan border panel.")]
        public int BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                if (value < 0) value = 0;
                _borderThickness = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Menampilkan bayangan di bawah panel.")]
        public bool DropShadow
        {
            get { return _dropShadow; }
            set
            {
                _dropShadow = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Warna bayangan.")]
        public Color ShadowColor
        {
            get { return _shadowColor; }
            set
            {
                _shadowColor = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Kedalaman (jarak) bayangan dari panel.")]
        public int ShadowDepth
        {
            get { return _shadowDepth; }
            set
            {
                if (value < 0) value = 0;
                _shadowDepth = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Panel")]
        [Description("Radius blur untuk bayangan.")]
        public int ShadowBlur
        {
            get { return _shadowBlur; }
            set
            {
                if (value < 0) value = 0;
                _shadowBlur = value;
                this.Invalidate();
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Untuk rendering yang halus
            g.PixelOffsetMode = PixelOffsetMode.Half; // Penting: Ini bisa membantu mengurangi "kebocoran" pixel

            // Awalnya, rectangle untuk seluruh area gambar (termasuk shadow)
            // Ini akan menjadi area efektif untuk background dan border utama.
            Rectangle drawRect = new Rectangle(0, 0, this.Width, this.Height);

            // Sesuaikan drawRect jika ada shadow
            if (_dropShadow && _shadowDepth > 0)
            {
                drawRect.Width -= _shadowDepth;
                drawRect.Height -= _shadowDepth;
            }

            // Sesuaikan drawRect untuk border, sehingga border tergambar di dalam area yang kita harapkan.
            // Kita akan menggambar path untuk background/border sedikit lebih kecil.
            int borderAdjust = _borderThickness; // Gunakan ketebalan border penuh untuk penyesuaian
            Rectangle mainShapeRect = new Rectangle(
                drawRect.X + (borderAdjust / 2),
                drawRect.Y + (borderAdjust / 2),
                drawRect.Width - borderAdjust,
                drawRect.Height - borderAdjust
            );

            // Pastikan cornerRadius tidak melebihi setengah dari dimensi terkecil
            int effectiveCornerRadius = _cornerRadius;
            if (effectiveCornerRadius > Math.Min(mainShapeRect.Width, mainShapeRect.Height) / 2)
                effectiveCornerRadius = Math.Min(mainShapeRect.Width, mainShapeRect.Height) / 2;
            if (effectiveCornerRadius < 0) effectiveCornerRadius = 0;


            // 1. Gambar Bayangan (jika aktif)
            if (_dropShadow && _shadowDepth > 0 && _shadowBlur > 0)
            {
                using (GraphicsPath shadowPath = GetRoundedRectanglePath(
                    mainShapeRect.X + _shadowDepth,
                    mainShapeRect.Y + _shadowDepth,
                    mainShapeRect.Width,
                    mainShapeRect.Height,
                    effectiveCornerRadius))
                {
                    for (int i = 0; i < _shadowBlur; i++)
                    {
                        // Pastikan alpha tidak 0 jika blur besar
                        int alpha = _shadowColor.A / (_shadowBlur > 0 ? _shadowBlur : 1);
                        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(
                            alpha, _shadowColor.R, _shadowColor.G, _shadowColor.B)))
                        {
                            g.FillPath(shadowBrush, shadowPath);
                        }
                    }
                }
            }

            // 2. Gambar Background Panel dan Border
            using (GraphicsPath panelPath = GetRoundedRectanglePath(
                mainShapeRect.X,
                mainShapeRect.Y,
                mainShapeRect.Width,
                mainShapeRect.Height,
                effectiveCornerRadius))
            {
                // Isi background
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, panelPath);
                }

                // Gambar border
                if (_borderThickness > 0)
                {
                    using (Pen pen = new Pen(_borderColor, _borderThickness))
                    {
                        g.DrawPath(pen, panelPath);
                    }
                }
            }
        }

        private void InitializeComponent()
        {

        }

        // Helper method untuk membuat GraphicsPath persegi panjang dengan sudut tumpul (Tidak Berubah)
        private GraphicsPath GetRoundedRectanglePath(int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(x, y, width, height);

            // Jika radius terlalu besar untuk dimensi, sesuaikan agar tidak crash
            if (width < 2 * radius) radius = width / 2;
            if (height < 2 * radius) radius = height / 2;

            if (radius <= 0) // Jika radius 0 atau negatif, buat persegi biasa
            {
                path.AddRectangle(rect);
            }
            else
            {
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Top-left
                path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90); // Top-right
                path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90); // Bottom-right
                path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90); // Bottom-left
            }
            path.CloseFigure();
            return path;
        }
    }
}