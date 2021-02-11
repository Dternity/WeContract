using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WeContract.UserControls
{
    
    public partial class WCProgressBar : UserControl
    {
        private uint _minValue;
        private uint _value;
        private uint _maxValue;
        private bool _showPercentage;
        private Color _progressColor;
        private Color _borderColor;
        private bool _showBorder;
        private StringAlignment _alignment;
        private StringAlignment _lineAlignment;

        [Browsable(true)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public bool ShowPercentage
        {
            get => _showPercentage;
            set
            {
                _showPercentage = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public bool ShowBorder
        {
            get => _showBorder;
            set
            {
                _showBorder = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public Color ProgressColor
        {
            get => _progressColor;
            set
            {
                _progressColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DefaultValue(0)]
        public uint MinValue
        {
            get => _minValue;
            set
            {
                Invalidate();
                if (value > _maxValue)
                {
                    _minValue = _maxValue;
                    _value = _minValue;
                    return;
                }

                _minValue = value;
            }
        }

        [Browsable(true)]
        [DefaultValue(50)]
        public uint Value
        {
            get => _value;
            set
            {
                Invalidate();
                if (value < _minValue)
                {
                    _value = _minValue;
                    return;
                }

                if (value > _maxValue)
                {
                    _value = _maxValue;
                    return;
                }

                _value = value;
            }
        }

        [Browsable(true)]
        [DefaultValue(100)]
        public uint MaxValue
        {
            get => _maxValue;
            set
            {
                Invalidate();
                if (value < _minValue)
                {
                    _maxValue = _minValue;
                    _value = _minValue;
                    return;
                }

                _maxValue = value;
            }
        }

        [Browsable(true)]
        public StringAlignment LineAlignment
        {
            get => _lineAlignment;
            set
            {
                _lineAlignment = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public StringAlignment Alignment
        {
            get => _alignment;
            set
            {
                _alignment = value;
                Invalidate();
            }
        }

        public WCProgressBar()
        {
            InitializeComponent();
            _minValue = 0;
            _value = 50;
            _maxValue = 100;
            _alignment = StringAlignment.Near;
            _lineAlignment = StringAlignment.Center;
            _showPercentage = true;
            _showBorder = true;
            _progressColor = Color.Aqua;
            _borderColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var bgBrush = new SolidBrush(BackColor);
            var progressBrush = new SolidBrush(ProgressColor);

            g.InterpolationMode = InterpolationMode.High;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.CompositingQuality = CompositingQuality.HighQuality;

            var percent = (_value - _minValue) / (float)(_maxValue - _minValue);

            g.FillRectangle(bgBrush, Bounds);
            g.FillRectangle(progressBrush, new Rectangle(0, 0, (int)(Width * percent), Height));

            if (_showBorder)
            {
                var borderPen = new Pen(BorderColor);

                g.DrawRectangle(borderPen, new Rectangle(0, 0, Width - 1, Height - 1));
                borderPen.Dispose();
            }

            if (_showPercentage)
            {
                var format = new StringFormat()
                {
                    Alignment = Alignment,
                    LineAlignment = LineAlignment
                };

                var emSize = g.DpiY * Font.Size / 72;
                var p = new GraphicsPath();

                p.AddString(
                    $@"{(int)(percent * 100)}%",
                    Font.FontFamily,
                    (int)Font.Style,
                    emSize,
                    ClientRectangle,
                    format);

                g.FillPath(new SolidBrush(ForeColor), p);
                p.Dispose();
            }

            bgBrush.Dispose();
            progressBrush.Dispose();
            g.Dispose();
        }
    }
}
