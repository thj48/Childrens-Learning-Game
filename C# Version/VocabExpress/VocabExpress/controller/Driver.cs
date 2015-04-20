using System;
using System.Windows.Forms;
using VocabExpress.io;

namespace VocabExpress
{
    internal static class Driver
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var fileManager = new FileManager();
            var listManager = new ListManager(fileManager);
            var testManager = new TestManager(listManager, fileManager);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(testManager, listManager, fileManager));
        }
    }
}