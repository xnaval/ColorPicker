using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    /// <summary>Dialog to pick a color</summary>
    public partial class ColorPickerFrm : Form
    {
        #region Private Fields

        private int _a = 0xFF;
        private int _c, _m, _y, _k;
        private double _h, _s, _v;
        private int _r, _g, _b;
        private bool _tr = true;

        #endregion Private Fields

        #region Constructors

        /// <summary>Constructor</summary>
        public ColorPickerFrm()
            : this(Color.Red)
        {
        }

        /// <summary>Constructor</summary>
        /// <param name="col">Starting color</param>
        public ColorPickerFrm(Color col)
        {
            InitializeComponent();

            _r = col.R;
            _g = col.G;
            _b = col.B;
            _a = col.A;
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = col;
            tcPanel.Color2 = col;
            rbHue.Checked = true;
            updateTextBoxes();
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>Alpha value (0 - Totally transparent, 255 - Totally opaque) </summary>
        public int A => _a;

        /// <summary>Result Color value as an ARGB int</summary>
        public int ARGB
        {
            get => ((_a & 0xFF) << 24) + ((_r & 0xFF) << 16) + ((_g & 0xFF) << 8) + (_b & 0xFF);
            set
            {
                if (_a != ((value >> 24) & 0xFF) || _r != ((value >> 16) & 0xFF) || _g != ((value >> 8) & 0xFF) || _b != (value & 0xFF))
                {
                    _a = (value >> 24) & 0xFF;
                    _r = (value >> 16) & 0xFF;
                    _g = (value >> 8) & 0xFF;
                    _b = value & 0xFF;
                    ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                    vColorSlider.SetRGB(_r, _g, _b);
                    cBox.SetRGB(_r, _g, _b);
                    tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                    updateTextBoxes();
                }
            }
        }

        /// <summary>Blue value (0 - 255)</summary>
        public int B => _b;

        /// <summary>Cyan value (0 - 255)</summary>
        public int C => _c;

        /// <summary>Result Color value as as System.Drawing.Color</summary>
        public Color Color
        {
            get => Color.FromArgb(_a, _r, _g, _b);
            set
            {
                if (_a != value.A || _r != value.R || _g != value.G || B != value.B)
                {
                    _a = value.A;
                    _r = value.R;
                    _g = value.G;
                    _b = value.B;
                    ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                    vColorSlider.SetRGB(_r, _g, _b);
                    cBox.SetRGB(_r, _g, _b);
                    tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                    updateTextBoxes();
                }
            }
        }

        /// <summary>Control DrawStyle (Hue, Saturation, Brightness, Red, Green or Blue)</summary>
        public DrawStyles DrawStyle
        {
            get
            {
                if (rbHue.Checked)
                    return DrawStyles.Hue;
                else if (rbSat.Checked)
                    return DrawStyles.Saturation;
                else if (rbVal.Checked)
                    return DrawStyles.Brightness;
                else if (rbRed.Checked)
                    return DrawStyles.Red;
                else if (rbGreen.Checked)
                    return DrawStyles.Green;
                else if (rbBlue.Checked)
                    return DrawStyles.Blue;
                else
                    return DrawStyles.Hue;
            }
            set
            {
                switch (value)
                {
                    case DrawStyles.Hue:
                        rbHue.Checked = true;
                        break;
                    case DrawStyles.Saturation:
                        rbSat.Checked = true;
                        break;
                    case DrawStyles.Brightness:
                        rbVal.Checked = true;
                        break;
                    case DrawStyles.Red:
                        rbRed.Checked = true;
                        break;
                    case DrawStyles.Green:
                        rbGreen.Checked = true;
                        break;
                    case DrawStyles.Blue:
                        rbBlue.Checked = true;
                        break;
                    default:
                        rbHue.Checked = true;
                        break;
                }
            }
        }

        /// <summary>Green value (0 - 255)</summary>
        public int G => _g;

        /// <summary>Hue value (0.0 - 360.0)</summary>
        public double H => _h;

        /// <summary>Black value (0 - 255)</summary>
        public int K => _k;

        /// <summary>Magenta value (0 - 255)</summary>
        public int M => _m;

        /// <summary>Red value (0 - 255)</summary>
        public int R => _r;

        /// <summary>Result Color value as a RGB int (alpha is set to 255)</summary>
        public int RGB
        {
            get => ((_r & 0xFF) << 16) + ((_g & 0xFF) << 8) + (_b & 0xFF);
            set
            {
                if (_a != 0xFF || _r != ((value >> 16) & 0xFF) || _g != ((value >> 8) & 0xFF) || _b != (value & 0xFF))
                {
                    _a = 0xFF;
                    _r = (value >> 16) & 0xFF;
                    _g = (value >> 8) & 0xFF;
                    _b = value & 0xFF;
                    ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                    vColorSlider.SetRGB(_r, _g, _b);
                    cBox.SetRGB(_r, _g, _b);
                    tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                    updateTextBoxes();
                }
            }
        }

        /// <summary>Saturation value (0.0 - 1.0)</summary>
        public double S => _s;

        /// <summary>Use transparency (alpha) or not</summary>
        public bool UseTransparency
        {
            get => _tr;
            set
            {
                if (_tr != value)
                {
                    _tr = value;
                    lbTransp.Visible = _tr;
                    tbTransp.Visible = _tr;
                    txTransp.Visible = _tr;
                    if (!_tr && _a != 0xFF)
                    {
                        _a = 0xFF;
                        if (tcPanel.Color1.A != 0xFF)
                            tcPanel.Color1 = Color.FromArgb(_a, tcPanel.Color1.R, tcPanel.Color1.G, tcPanel.Color1.B);
                        tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                    }
                    updateTextBoxes();
                }
            }
        }

        /// <summary>Value/Brightness value</summary>
        public double V => _v;

        /// <summary>Yellow value (0 - 255)</summary>
        public int Y => _y;

        #endregion Public Properties

        #region Private Methods

        /// <summary>Process the Scrolled event from the ColorBox</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_Scrolled(object sender, EventArgs e)
        {
            if (cBox.DrawStyle == DrawStyles.Red || cBox.DrawStyle == DrawStyles.Green || cBox.DrawStyle == DrawStyles.Blue)
            {
                _r = cBox.R;
                _g = cBox.G;
                _b = cBox.B;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                vColorSlider.SetRGB(_r, _g, _b);
            }
            else
            {
                _h = cBox.H;
                _s = cBox.S;
                _v = cBox.V;
                ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
                vColorSlider.SetHSV(_h, _s, _v);
            }
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Change the DrawStyle to Blue</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Blue;
                cBox.DrawStyle = DrawStyles.Blue;
            }
        }

        /// <summary>Change the DrawStyle to Green</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Green;
                cBox.DrawStyle = DrawStyles.Green;
            }
        }

        /// <summary>Change the DrawStyle to hue</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbHue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHue.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Hue;
                cBox.DrawStyle = DrawStyles.Hue;
            }
        }

        /// <summary>Change the DrawStyle to Red</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Red;
                cBox.DrawStyle = DrawStyles.Red;
            }
        }

        /// <summary>Change the DrawStyle to Saturation</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSat.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Saturation;
                cBox.DrawStyle = DrawStyles.Saturation;
            }
        }

        /// <summary>Change the DrawStyle to Brightness</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbVal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVal.Checked)
            {
                vColorSlider.DrawStyle = DrawStyles.Brightness;
                cBox.DrawStyle = DrawStyles.Brightness;
            }
        }

        /// <summary>The transparency value has changed from the TrackBar</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTransp_ValueChanged(object sender, EventArgs e)
        {
            int a = tbTransp.Value;
            if (a != txTransp.Int32Value)
                txTransp.Int32Value = a;
            _a = a < 0 ? 0 : a > 255 ? 255 : a;
            ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Changed the Black value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txBlack_Leave(object sender, EventArgs e)
        {
            int k = txBlack.Int32Value;
            if (k != _k)
            {
                _k = k < 0 ? 0 : k > 255 ? 255 : k;
                ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Blue value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txBlue_Leave(object sender, EventArgs e)
        {
            int b = txBlue.Int32Value;
            if (b != _b)
            {
                _b = b < 0 ? 0 : b > 255 ? 255 : b;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Cyan value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txCyan_Leave(object sender, EventArgs e)
        {
            int c = txCyan.Int32Value;
            if (c != _c)
            {
                _c = c < 0 ? 0 : c > 255 ? 255 : c;
                ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Color value from the decimal TexBox</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txDec_Leave(object sender, EventArgs e)
        {
            uint argb = txDec.UInt32Value;
            if (_tr)
                _a = (int)((argb >> 24) & 0xFF);
            else
                _a = 0xFF;
            _r = (int)((argb >> 16) & 0xFF);
            _g = (int)((argb >> 8) & 0xFF);
            _b = (int)(argb & 0xFF);
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Changed the Green value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txGreen_Leave(object sender, EventArgs e)
        {
            int g = txGreen.Int32Value;
            if (g != _g)
            {
                _g = g < 0 ? 0 : g > 255 ? 255 : g;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Color value form the Hex TexBox</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txHex_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txHex.Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.InvariantInfo, out int ihex))
                writeHexData();
            else
            {
                if (_tr)
                    _a = (ihex >> 24) & 0xFF;
                else
                    _a = 0xFF;
                _r = (ihex >> 16) & 0xFF;
                _g = (ihex >> 8) & 0xFF;
                _b = ihex & 0xFF;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Hue value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txHue_Leave(object sender, EventArgs e)
        {
            double h = txHue.DoubleValue;
            if (h != _h)
            {
                _h = h < 0.0 ? 0.0 : h > 360.0 ? 360.0 : h;
                ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Magenta value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txMagenta_Leave(object sender, EventArgs e)
        {
            int m = txMagenta.Int32Value;
            if (m != _m)
            {
                _m = m < 0 ? 0 : m > 255 ? 255 : m;
                ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Red value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txRed_Leave(object sender, EventArgs e)
        {
            int r = txRed.Int32Value;
            if (r != _r)
            {
                _r = r < 0 ? 0 : r > 255 ? 255 : r;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Saturation value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txSat_Leave(object sender, EventArgs e)
        {
            double s = txSat.DoubleValue;
            if (s != _s)
            {
                _s = (s < 0.0 ? 0.0 : s > 100.0 ? 100.0 : s) / 100.0;
                ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the transparency value from the TextBox</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txTransp_Leave(object sender, EventArgs e)
        {
            int a = txTransp.Int32Value;
            if (a != tbTransp.Value)
                tbTransp.Value = a;
            // The update is performed by tbTransp_ValueChanged function
        }

        /// <summary>Changed the Value/Brightness value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txVal_Leave(object sender, EventArgs e)
        {
            double v = txVal.DoubleValue;
            if (v != _v)
            {
                _v = (v < 0.0 ? 0.0 : v > 100.0 ? 100.0 : v) / 100.0;
                ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
                ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Changed the Yellow value</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txYellow_Leave(object sender, EventArgs e)
        {
            int y = txYellow.Int32Value;
            if (y != _y)
            {
                _y = y < 0 ? 0 : y > 255 ? 255 : y;
                ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                vColorSlider.SetRGB(_r, _g, _b);
                cBox.SetRGB(_r, _g, _b);
                tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
                updateTextBoxes();
            }
        }

        /// <summary>Update all the textBoxes</summary>
        private void updateTextBoxes()
        {
            if (_tr)
            {
                txTransp.Int32Value = _a;
                tbTransp.Value = _a;
            }
            txHue.DoubleValue = Math.Round(_h, 2);
            txSat.DoubleValue = Math.Round(_s * 100.0, 2);
            txVal.DoubleValue = Math.Round(_v * 100.0, 2);
            txCyan.Int32Value = _c;
            txMagenta.Int32Value = _m;
            txYellow.Int32Value = _y;
            txBlack.Int32Value = _k;
            txRed.Int32Value = _r;
            txGreen.Int32Value = _g;
            txBlue.Int32Value = _b;
            txDec.UInt32Value = _tr ? (uint)ARGB : (uint)RGB;
            writeHexData();
        }

        /// <summary>Process the Scrolled event from the VerticalColorSlider</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vColorSlider_Scrolled(object sender, EventArgs e)
        {
            if (vColorSlider.DrawStyle == DrawStyles.Red || vColorSlider.DrawStyle == DrawStyles.Green || vColorSlider.DrawStyle == DrawStyles.Blue)
            {
                _r = vColorSlider.R;
                _g = vColorSlider.G;
                _b = vColorSlider.B;
                ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
                _h = Math.Round(_h, 2);
                _s = Math.Round(_s, 4);
                _v = Math.Round(_v, 4);
                cBox.SetRGB(_r, _g, _b);
            }
            else
            {
                _h = vColorSlider.H;
                _s = vColorSlider.S;
                _v = vColorSlider.V;
                ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
                cBox.SetHSV(_h, _s, _v);
            }
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Write de Color value in to the Hex TextBox</summary>
        private void writeHexData()
        {
            if (_tr)
                txHex.Text = (_a & 0xFF).ToString("X2") + (_r & 0xFF).ToString("X2") + (_g & 0xFF).ToString("X2") + (_b & 0xFF).ToString("X2");
            else
                txHex.Text = (_r & 0xFF).ToString("X2") + (_g & 0xFF).ToString("X2") + (_b & 0xFF).ToString("X2");
        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>Sets the starting color ARGB components</summary>
        /// <param name="a">Alpha (0 - 255)</param>
        /// <param name="r">Red (0 - 255)</param>
        /// <param name="g">Green (0 - 255)</param>
        /// <param name="b">Blue (0 - 255)</param>
        public void SetStartingARGB(int a, int r, int g, int b)
        {
            _a = _tr ? (a & 0xFF) : 0xFF;
            _r = r & 0xFF;
            _g = g & 0xFF;
            _b = b & 0xFF;
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Sets the starting color CMYK components (alpha is set to 255)</summary>
        /// <param name="c">Cyan (0 - 255)</param>
        /// <param name="m">Magenta (0 - 255)</param>
        /// <param name="y">Yellow (0 - 255)</param>
        /// <param name="k">Black (0 - 255)</param>
        public void SetStartingCMYK(int c, int m, int y, int k)
        {
            _a = 0xFF;
            _c = c & 0xFF;
            _m = m & 0xFF;
            _y = y & 0xFF;
            _k = k & 0xFF;
            ColorUtil.CMYK2RGB(_c, _m, _y, _k, out _r, out _g, out _b);
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Constructor</summary>
        /// <param name="col">Starting color</param>
        public void SetStartingColor(Color col)
        {
            _r = col.R;
            _g = col.G;
            _b = col.B;
            _a = _tr ? col.A : 0XFF;
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Sets the starting color HSV components (alpha is set to 255)</summary>
        /// <param name="h">Hue (0.0 - 360.0)</param>
        /// <param name="s">Saturation (0.0 - 1.0)</param>
        /// <param name="v">Value (0.0 - 1.0)</param>
        public void SetStartingHSV(double h, double s, double v)
        {
            _a = 0xFF;
            _h = h < 0.0 ? 0.0 : h > 360.0 ? 360.0 : h;
            _s = s < 0.0 ? 0.0 : h > 1.0 ? 1.0 : s;
            _v = v < 0.0 ? 0.0 : h > 1.0 ? 1.0 : v;
            _a = 0xFF;
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            ColorUtil.HSV2RGB(_h, _s, _v, out _r, out _g, out _b);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Sets the starting color RGB components (alpha is set to 255)</summary>
        /// <param name="r">Red (0 - 255)</param>
        /// <param name="g">Green (0 - 255)</param>
        /// <param name="b">Blue (0 - 255)</param>
        public void SetStartingRGB(int r, int g, int b)
        {
            _a = 0xFF;
            _r = r & 0xFF;
            _g = g & 0xFF;
            _b = b & 0xFF;
            _a = 0xFF;
            ColorUtil.RGB2HSV(_r, _g, _b, out _h, out _s, out _v);
            _h = Math.Round(_h, 2);
            _s = Math.Round(_s, 4);
            _v = Math.Round(_v, 4);
            ColorUtil.RGB2CMYK(_r, _g, _b, out _c, out _m, out _y, out _k);
            vColorSlider.SetRGB(_r, _g, _b);
            cBox.SetRGB(_r, _g, _b);
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        /// <summary>Sets the starting alpha component</summary>
        /// <param name="a">Alpha (0 - 255)</param>
        public void SetStartingAlpha(int a)
        {
            _a = _tr ? (a & 0xFF) : 0xFF;
            tcPanel.Color1 = Color.FromArgb(_a, _r, _g, _b);
            tcPanel.Color2 = Color.FromArgb(_a, _r, _g, _b);
            updateTextBoxes();
        }

        #endregion Public Methods
    }
}