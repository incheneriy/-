using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenCVLib2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// изменения для mercurial 1
        /// изменения для mercurial 2
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
