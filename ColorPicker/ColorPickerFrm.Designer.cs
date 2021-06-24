
namespace ColorPicker
{
    partial class ColorPickerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerFrm));
            this.lbVal = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbHue = new System.Windows.Forms.Label();
            this.lbBlack = new System.Windows.Forms.Label();
            this.lbYellow = new System.Windows.Forms.Label();
            this.lbMagenta = new System.Windows.Forms.Label();
            this.lbCyan = new System.Windows.Forms.Label();
            this.lbHex = new System.Windows.Forms.Label();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbVal = new System.Windows.Forms.RadioButton();
            this.rbSat = new System.Windows.Forms.RadioButton();
            this.rbHue = new System.Windows.Forms.RadioButton();
            this.txHex = new System.Windows.Forms.TextBox();
            this.lbTransp = new System.Windows.Forms.Label();
            this.tbTransp = new System.Windows.Forms.TrackBar();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txTransp = new ColorPicker.NumericTextBox();
            this.tcPanel = new ColorPicker.TwoColorPanel();
            this.txDec = new ColorPicker.NumericTextBox();
            this.cBox = new ColorPicker.ColorBox();
            this.txBlack = new ColorPicker.NumericTextBox();
            this.txYellow = new ColorPicker.NumericTextBox();
            this.txMagenta = new ColorPicker.NumericTextBox();
            this.txCyan = new ColorPicker.NumericTextBox();
            this.txBlue = new ColorPicker.NumericTextBox();
            this.txGreen = new ColorPicker.NumericTextBox();
            this.txRed = new ColorPicker.NumericTextBox();
            this.txVal = new ColorPicker.NumericTextBox();
            this.txSat = new ColorPicker.NumericTextBox();
            this.txHue = new ColorPicker.NumericTextBox();
            this.vColorSlider = new ColorPicker.VerticalColorSlider();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVal
            // 
            this.lbVal.AutoSize = true;
            this.lbVal.Location = new System.Drawing.Point(427, 224);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(15, 13);
            this.lbVal.TabIndex = 27;
            this.lbVal.Text = "%";
            // 
            // lbSat
            // 
            this.lbSat.AutoSize = true;
            this.lbSat.Location = new System.Drawing.Point(427, 202);
            this.lbSat.Name = "lbSat";
            this.lbSat.Size = new System.Drawing.Size(15, 13);
            this.lbSat.TabIndex = 26;
            this.lbSat.Text = "%";
            // 
            // lbHue
            // 
            this.lbHue.AutoSize = true;
            this.lbHue.Location = new System.Drawing.Point(427, 180);
            this.lbHue.Name = "lbHue";
            this.lbHue.Size = new System.Drawing.Size(11, 13);
            this.lbHue.TabIndex = 25;
            this.lbHue.Text = "°";
            // 
            // lbBlack
            // 
            this.lbBlack.AutoSize = true;
            this.lbBlack.Location = new System.Drawing.Point(442, 222);
            this.lbBlack.Name = "lbBlack";
            this.lbBlack.Size = new System.Drawing.Size(17, 13);
            this.lbBlack.TabIndex = 31;
            this.lbBlack.Text = "K:";
            // 
            // lbYellow
            // 
            this.lbYellow.AutoSize = true;
            this.lbYellow.Location = new System.Drawing.Point(442, 201);
            this.lbYellow.Name = "lbYellow";
            this.lbYellow.Size = new System.Drawing.Size(17, 13);
            this.lbYellow.TabIndex = 30;
            this.lbYellow.Text = "Y:";
            // 
            // lbMagenta
            // 
            this.lbMagenta.AutoSize = true;
            this.lbMagenta.Location = new System.Drawing.Point(442, 180);
            this.lbMagenta.Name = "lbMagenta";
            this.lbMagenta.Size = new System.Drawing.Size(19, 13);
            this.lbMagenta.TabIndex = 29;
            this.lbMagenta.Text = "M:";
            // 
            // lbCyan
            // 
            this.lbCyan.AutoSize = true;
            this.lbCyan.Location = new System.Drawing.Point(442, 159);
            this.lbCyan.Name = "lbCyan";
            this.lbCyan.Size = new System.Drawing.Size(17, 13);
            this.lbCyan.TabIndex = 28;
            this.lbCyan.Text = "C:";
            // 
            // lbHex
            // 
            this.lbHex.AutoSize = true;
            this.lbHex.Location = new System.Drawing.Point(328, 255);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(14, 13);
            this.lbHex.TabIndex = 24;
            this.lbHex.Text = "#";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(328, 147);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(35, 17);
            this.rbBlue.TabIndex = 20;
            this.rbBlue.Text = "B:";
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(328, 125);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(36, 17);
            this.rbGreen.TabIndex = 19;
            this.rbGreen.Text = "G:";
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(328, 103);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(36, 17);
            this.rbRed.TabIndex = 18;
            this.rbRed.Text = "R:";
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbVal
            // 
            this.rbVal.AutoSize = true;
            this.rbVal.Location = new System.Drawing.Point(328, 222);
            this.rbVal.Name = "rbVal";
            this.rbVal.Size = new System.Drawing.Size(35, 17);
            this.rbVal.TabIndex = 23;
            this.rbVal.Text = "V:";
            this.rbVal.CheckedChanged += new System.EventHandler(this.rbVal_CheckedChanged);
            // 
            // rbSat
            // 
            this.rbSat.AutoSize = true;
            this.rbSat.Location = new System.Drawing.Point(328, 200);
            this.rbSat.Name = "rbSat";
            this.rbSat.Size = new System.Drawing.Size(35, 17);
            this.rbSat.TabIndex = 22;
            this.rbSat.Text = "S:";
            this.rbSat.CheckedChanged += new System.EventHandler(this.rbSat_CheckedChanged);
            // 
            // rbHue
            // 
            this.rbHue.AutoSize = true;
            this.rbHue.Checked = true;
            this.rbHue.Location = new System.Drawing.Point(328, 178);
            this.rbHue.Name = "rbHue";
            this.rbHue.Size = new System.Drawing.Size(36, 17);
            this.rbHue.TabIndex = 21;
            this.rbHue.TabStop = true;
            this.rbHue.Text = "H:";
            this.rbHue.CheckedChanged += new System.EventHandler(this.rbHue_CheckedChanged);
            // 
            // txHex
            // 
            this.txHex.Location = new System.Drawing.Point(353, 252);
            this.txHex.Name = "txHex";
            this.txHex.Size = new System.Drawing.Size(68, 20);
            this.txHex.TabIndex = 11;
            this.txHex.Leave += new System.EventHandler(this.txHex_Leave);
            // 
            // lbTransp
            // 
            this.lbTransp.AutoSize = true;
            this.lbTransp.Location = new System.Drawing.Point(328, 83);
            this.lbTransp.Name = "lbTransp";
            this.lbTransp.Size = new System.Drawing.Size(20, 13);
            this.lbTransp.TabIndex = 17;
            this.lbTransp.Text = "Tr:";
            // 
            // tbTransp
            // 
            this.tbTransp.Location = new System.Drawing.Point(346, 79);
            this.tbTransp.Maximum = 255;
            this.tbTransp.Name = "tbTransp";
            this.tbTransp.Size = new System.Drawing.Size(115, 45);
            this.tbTransp.TabIndex = 16;
            this.tbTransp.TabStop = false;
            this.tbTransp.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTransp.ValueChanged += new System.EventHandler(this.tbTransp_ValueChanged);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCancel.Location = new System.Drawing.Point(443, 283);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOk.Location = new System.Drawing.Point(362, 283);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 32;
            this.btOk.Text = "Accept";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // txTransp
            // 
            this.txTransp.AllowDecimal = false;
            this.txTransp.AllowNull = false;
            this.txTransp.AllowSign = false;
            this.txTransp.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txTransp.DoubleValue = 0D;
            this.txTransp.Format = "";
            this.txTransp.Int32Value = 0;
            this.txTransp.Location = new System.Drawing.Point(467, 80);
            this.txTransp.Name = "txTransp";
            this.txTransp.Size = new System.Drawing.Size(51, 20);
            this.txTransp.TabIndex = 6;
            this.txTransp.Text = "0";
            this.txTransp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txTransp.UInt32Value = ((uint)(0u));
            this.txTransp.Leave += new System.EventHandler(this.txTransp_Leave);
            // 
            // tcPanel
            // 
            this.tcPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcPanel.Color1 = System.Drawing.Color.Red;
            this.tcPanel.Color2 = System.Drawing.Color.Orange;
            this.tcPanel.Location = new System.Drawing.Point(328, 14);
            this.tcPanel.Name = "tcPanel";
            this.tcPanel.Size = new System.Drawing.Size(190, 59);
            this.tcPanel.TabIndex = 15;
            // 
            // txDec
            // 
            this.txDec.AllowDecimal = false;
            this.txDec.AllowNull = false;
            this.txDec.AllowSign = false;
            this.txDec.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txDec.DoubleValue = 0D;
            this.txDec.Format = "";
            this.txDec.Int32Value = 0;
            this.txDec.Location = new System.Drawing.Point(427, 252);
            this.txDec.Name = "txDec";
            this.txDec.Size = new System.Drawing.Size(91, 20);
            this.txDec.TabIndex = 12;
            this.txDec.Text = "0";
            this.txDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txDec.UInt32Value = ((uint)(0u));
            this.txDec.Leave += new System.EventHandler(this.txDec_Leave);
            // 
            // cBox
            // 
            this.cBox.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cBox.DrawStyle = ColorPicker.DrawStyles.Hue;
            this.cBox.Location = new System.Drawing.Point(12, 12);
            this.cBox.MinimumSize = new System.Drawing.Size(265, 265);
            this.cBox.Name = "cBox";
            this.cBox.RGB = 16711680;
            this.cBox.Size = new System.Drawing.Size(265, 265);
            this.cBox.TabIndex = 13;
            this.cBox.Scrolled += new System.EventHandler(this.cBox_Scrolled);
            // 
            // txBlack
            // 
            this.txBlack.AllowDecimal = false;
            this.txBlack.AllowNull = false;
            this.txBlack.AllowSign = false;
            this.txBlack.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txBlack.DoubleValue = 0D;
            this.txBlack.Format = "";
            this.txBlack.Int32Value = 0;
            this.txBlack.Location = new System.Drawing.Point(467, 219);
            this.txBlack.Name = "txBlack";
            this.txBlack.Size = new System.Drawing.Size(51, 20);
            this.txBlack.TabIndex = 10;
            this.txBlack.Text = "0";
            this.txBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txBlack.UInt32Value = ((uint)(0u));
            this.txBlack.Leave += new System.EventHandler(this.txBlack_Leave);
            // 
            // txYellow
            // 
            this.txYellow.AllowDecimal = false;
            this.txYellow.AllowNull = false;
            this.txYellow.AllowSign = false;
            this.txYellow.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txYellow.DoubleValue = 0D;
            this.txYellow.Format = "";
            this.txYellow.Int32Value = 0;
            this.txYellow.Location = new System.Drawing.Point(467, 198);
            this.txYellow.Name = "txYellow";
            this.txYellow.Size = new System.Drawing.Size(51, 20);
            this.txYellow.TabIndex = 9;
            this.txYellow.Text = "0";
            this.txYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txYellow.UInt32Value = ((uint)(0u));
            this.txYellow.Leave += new System.EventHandler(this.txYellow_Leave);
            // 
            // txMagenta
            // 
            this.txMagenta.AllowDecimal = false;
            this.txMagenta.AllowNull = false;
            this.txMagenta.AllowSign = false;
            this.txMagenta.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txMagenta.DoubleValue = 0D;
            this.txMagenta.Format = "";
            this.txMagenta.Int32Value = 0;
            this.txMagenta.Location = new System.Drawing.Point(467, 177);
            this.txMagenta.Name = "txMagenta";
            this.txMagenta.Size = new System.Drawing.Size(51, 20);
            this.txMagenta.TabIndex = 8;
            this.txMagenta.Text = "0";
            this.txMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txMagenta.UInt32Value = ((uint)(0u));
            this.txMagenta.Leave += new System.EventHandler(this.txMagenta_Leave);
            // 
            // txCyan
            // 
            this.txCyan.AllowDecimal = false;
            this.txCyan.AllowNull = false;
            this.txCyan.AllowSign = false;
            this.txCyan.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txCyan.DoubleValue = 0D;
            this.txCyan.Format = "";
            this.txCyan.Int32Value = 0;
            this.txCyan.Location = new System.Drawing.Point(467, 156);
            this.txCyan.Name = "txCyan";
            this.txCyan.Size = new System.Drawing.Size(51, 20);
            this.txCyan.TabIndex = 7;
            this.txCyan.Text = "0";
            this.txCyan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txCyan.UInt32Value = ((uint)(0u));
            this.txCyan.Leave += new System.EventHandler(this.txCyan_Leave);
            // 
            // txBlue
            // 
            this.txBlue.AllowDecimal = false;
            this.txBlue.AllowNull = false;
            this.txBlue.AllowSign = false;
            this.txBlue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txBlue.DoubleValue = 0D;
            this.txBlue.Format = "";
            this.txBlue.Int32Value = 0;
            this.txBlue.Location = new System.Drawing.Point(370, 146);
            this.txBlue.Name = "txBlue";
            this.txBlue.Size = new System.Drawing.Size(51, 20);
            this.txBlue.TabIndex = 2;
            this.txBlue.Text = "0";
            this.txBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txBlue.UInt32Value = ((uint)(0u));
            this.txBlue.Leave += new System.EventHandler(this.txBlue_Leave);
            // 
            // txGreen
            // 
            this.txGreen.AllowDecimal = false;
            this.txGreen.AllowNull = false;
            this.txGreen.AllowSign = false;
            this.txGreen.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txGreen.DoubleValue = 0D;
            this.txGreen.Format = "";
            this.txGreen.Int32Value = 0;
            this.txGreen.Location = new System.Drawing.Point(370, 124);
            this.txGreen.Name = "txGreen";
            this.txGreen.Size = new System.Drawing.Size(51, 20);
            this.txGreen.TabIndex = 1;
            this.txGreen.Text = "0";
            this.txGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txGreen.UInt32Value = ((uint)(0u));
            this.txGreen.Leave += new System.EventHandler(this.txGreen_Leave);
            // 
            // txRed
            // 
            this.txRed.AllowDecimal = false;
            this.txRed.AllowNull = false;
            this.txRed.AllowSign = false;
            this.txRed.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txRed.DoubleValue = 0D;
            this.txRed.Format = "";
            this.txRed.Int32Value = 0;
            this.txRed.Location = new System.Drawing.Point(370, 102);
            this.txRed.Name = "txRed";
            this.txRed.Size = new System.Drawing.Size(51, 20);
            this.txRed.TabIndex = 0;
            this.txRed.Text = "0";
            this.txRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txRed.UInt32Value = ((uint)(0u));
            this.txRed.Leave += new System.EventHandler(this.txRed_Leave);
            // 
            // txVal
            // 
            this.txVal.AllowNull = false;
            this.txVal.AllowSign = false;
            this.txVal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txVal.DoubleValue = 0D;
            this.txVal.Format = "##0.##";
            this.txVal.Int32Value = 0;
            this.txVal.Location = new System.Drawing.Point(370, 221);
            this.txVal.Name = "txVal";
            this.txVal.Size = new System.Drawing.Size(51, 20);
            this.txVal.TabIndex = 5;
            this.txVal.Text = "0";
            this.txVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txVal.UInt32Value = ((uint)(0u));
            this.txVal.Leave += new System.EventHandler(this.txVal_Leave);
            // 
            // txSat
            // 
            this.txSat.AllowNull = false;
            this.txSat.AllowSign = false;
            this.txSat.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txSat.DoubleValue = 0D;
            this.txSat.Format = "##0.##";
            this.txSat.Int32Value = 0;
            this.txSat.Location = new System.Drawing.Point(370, 199);
            this.txSat.Name = "txSat";
            this.txSat.Size = new System.Drawing.Size(51, 20);
            this.txSat.TabIndex = 4;
            this.txSat.Text = "0";
            this.txSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txSat.UInt32Value = ((uint)(0u));
            this.txSat.Leave += new System.EventHandler(this.txSat_Leave);
            // 
            // txHue
            // 
            this.txHue.AllowNull = false;
            this.txHue.AllowSign = false;
            this.txHue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txHue.DoubleValue = 0D;
            this.txHue.Format = "##0.##";
            this.txHue.Int32Value = 0;
            this.txHue.Location = new System.Drawing.Point(370, 177);
            this.txHue.Name = "txHue";
            this.txHue.Size = new System.Drawing.Size(51, 20);
            this.txHue.TabIndex = 3;
            this.txHue.Text = "0";
            this.txHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txHue.UInt32Value = ((uint)(0u));
            this.txHue.Leave += new System.EventHandler(this.txHue_Leave);
            // 
            // vColorSlider
            // 
            this.vColorSlider.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vColorSlider.DrawStyle = ColorPicker.DrawStyles.Hue;
            this.vColorSlider.Location = new System.Drawing.Point(283, 12);
            this.vColorSlider.MinimumSize = new System.Drawing.Size(39, 265);
            this.vColorSlider.Name = "vColorSlider";
            this.vColorSlider.RGB = 16777215;
            this.vColorSlider.Size = new System.Drawing.Size(39, 265);
            this.vColorSlider.TabIndex = 14;
            this.vColorSlider.Scrolled += new System.EventHandler(this.vColorSlider_Scrolled);
            // 
            // ColorPickerFrm
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(536, 315);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbTransp);
            this.Controls.Add(this.txTransp);
            this.Controls.Add(this.tcPanel);
            this.Controls.Add(this.txDec);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.lbVal);
            this.Controls.Add(this.lbSat);
            this.Controls.Add(this.lbHue);
            this.Controls.Add(this.lbBlack);
            this.Controls.Add(this.lbYellow);
            this.Controls.Add(this.lbMagenta);
            this.Controls.Add(this.lbCyan);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.rbVal);
            this.Controls.Add(this.rbSat);
            this.Controls.Add(this.rbHue);
            this.Controls.Add(this.txHex);
            this.Controls.Add(this.txBlack);
            this.Controls.Add(this.txYellow);
            this.Controls.Add(this.txMagenta);
            this.Controls.Add(this.txCyan);
            this.Controls.Add(this.txBlue);
            this.Controls.Add(this.txGreen);
            this.Controls.Add(this.txRed);
            this.Controls.Add(this.txVal);
            this.Controls.Add(this.txSat);
            this.Controls.Add(this.txHue);
            this.Controls.Add(this.vColorSlider);
            this.Controls.Add(this.tbTransp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.tbTransp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalColorSlider vColorSlider;
        private System.Windows.Forms.Label lbVal;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.Label lbHue;
        private System.Windows.Forms.Label lbBlack;
        private System.Windows.Forms.Label lbYellow;
        private System.Windows.Forms.Label lbMagenta;
        private System.Windows.Forms.Label lbCyan;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbVal;
        private System.Windows.Forms.RadioButton rbSat;
        private System.Windows.Forms.RadioButton rbHue;
        private System.Windows.Forms.TextBox txHex;
        private NumericTextBox txBlack;
        private NumericTextBox txYellow;
        private NumericTextBox txMagenta;
        private NumericTextBox txCyan;
        private NumericTextBox txBlue;
        private NumericTextBox txGreen;
        private NumericTextBox txRed;
        private NumericTextBox txVal;
        private NumericTextBox txSat;
        private NumericTextBox txHue;
        private ColorBox cBox;
        private NumericTextBox txDec;
        private TwoColorPanel tcPanel;
        private NumericTextBox txTransp;
        private System.Windows.Forms.Label lbTransp;
        private System.Windows.Forms.TrackBar tbTransp;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}