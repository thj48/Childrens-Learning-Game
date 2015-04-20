using System;
using System.Windows.Forms;
using VocabExpress.io;

namespace VocabExpress
{
    public partial class TestResults : Form
    {
        /// <summary>
        ///     Constructs TestResults form
        /// </summary>
        public TestResults(FileManager afileManager, String fileName)
        {
            InitializeComponent();
            afileManager.readInFile(fileName);
            displayWordsTextBox.Text = afileManager.getResults();
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}