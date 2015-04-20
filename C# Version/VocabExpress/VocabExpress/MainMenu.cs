using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VocabExpress.io;

namespace VocabExpress
{
    public partial class MainMenu : Form
    {
        private const String REPORT_FILE = "Report.txt";
        private readonly FileManager fileManager;
        private readonly ListManager listManager;
        private readonly TestManager testManager;
        private readonly List<SpellingWord> wordList;

        /// <summary>
        ///     Constructs the main menu form
        /// </summary>
        public MainMenu(TestManager testManager, ListManager listManager, FileManager fileManager)
        {
            InitializeComponent();
            this.testManager = testManager;
            this.listManager = listManager;
            this.fileManager = fileManager;
            wordList = this.listManager.getSpellingWords();
        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            DialogResult dialogResult =
                MessageBox.Show(
                    "Are you sure you want to make a new list? All information pertaining the old list will be lost.",
                    "Make New List", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                listManager.clearAll();
                Form addWord = new AddWord(listManager);
                addWord.ShowDialog();
                listManager.saveWords();
            }
        }

        private void viewListButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            Form viewList = new ViewList(listManager);
            viewList.ShowDialog();
        }

        private void takeTestButton_Click(object sender, EventArgs e)
        {
            if (wordList.Count < 1)
            {
                errorLabel.Visible = true;
                return;
            }

            Form test = new Test(testManager);
            test.ShowDialog();
        }

        private void playMatchButton_Click(object sender, EventArgs e)
        {
            if (wordList.Count < 3)
            {
                errorLabel.Visible = true;
                return;
            }

            Form wordMatch = new WordMatch(listManager);
            wordMatch.ShowDialog();
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            Form testResultsForm = new TestResults(fileManager, REPORT_FILE);
            testResultsForm.ShowDialog();
        }
    }
}