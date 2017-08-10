using System.Windows.Forms;

namespace Systembolagskollen.Helpers
{
    public static class DirectoryHelper
    {
        public static string AppPath { get { return Application.ExecutablePath; } }
        public static string StartPath { get { return Application.StartupPath; } }
    }
}
