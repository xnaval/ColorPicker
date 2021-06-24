using System;
using System.Windows.Forms;

namespace ColorPicker
{
    static class Program
    {
        /// <summary>Main entry point for the application.</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
