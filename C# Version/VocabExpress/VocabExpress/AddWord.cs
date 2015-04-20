using System;
using System.Drawing;
using System.Windows.Forms;

namespace VocabExpress
{
    public partial class AddWord : Form
    {
        private readonly ListManager listManager;
        private SpellingWord word;

        /// <summary>
        ///     Constructs the addword form
        /// </summary>
        public AddWord(ListManager listManager)
        {
            InitializeComponent();
            this.listManager = listManager;
        }

        private void imageBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackgroundImage = new Bitmap(openFileDialog.FileName);
                finishButton.Enabled = true;
                addAnotherWordButton.Enabled = true;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                addWord();
                Close();
            }
        }

        private void addAnotherWordButton_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                addWord();
                resetForm();
            }
        }

        private void addWord()
        {
            String wordText = inputTextBox.Text;
            String image = openFileDialog.FileName;

            word = new SpellingWord(wordText, image);
            listManager.addWord(word);
        }

        private void resetForm()
        {
            pictureBox.BackgroundImage = null;
            inputTextBox.Clear();
            finishButton.Enabled = false;
            addAnotherWordButton.Enabled = false;
            errorLabel.Visible = false;
        }

        private bool checkValues()
        {
            String wordText = inputTextBox.Text;
            String image = openFileDialog.FileName;

            if (image.Equals("") || wordText.Equals(""))
            {
                errorLabel.Visible = true;
                return false;
            }
            return true;
        }
    }
}