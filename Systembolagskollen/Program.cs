using System;
using System.Windows.Forms;

/// <summary>
/// Petter Pettersson
/// 2016-06-09
/// </summary>

namespace Systembolagskollen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
