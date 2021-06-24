using System;
using System.Windows.Forms;

namespace ColorPicker
{
    /// <summary>ColorPickerFrm Launcher</summary>
    public partial class Form1 : Form
    {
        /// <summary>Constructor</summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Open ColorPickerFrm</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbColor_Click(object sender, EventArgs e)
        {
            ColorPickerFrm frm = new ColorPickerFrm(lbColor.BackColor)
            {
                UseTransparency = cbTrans.Checked
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                lbColor.BackColor = frm.Color;
            }
        }
    }
}
