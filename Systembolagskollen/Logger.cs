using System;
using System.IO;
using Systembolagskollen.Helpers;

/// <summary>
/// Petter Pettersson
/// 2016-05-18
/// </summary>

namespace Systembolagskollen
{
    public static class Logger
    {
        /// <summary>
        /// Skriver ett exception till en logger fil
        /// </summary>
        /// <param name="e"></param>
        public static void Write(Exception e)
        {
            var logPath = DirectoryHelper.StartPath + "\\logs.txt";
            File.AppendAllText(logPath, DateTime.Now + "\r\n" + e.ToString() + "\r\n\r\n", System.Text.Encoding.UTF8);
        }
    }
}
