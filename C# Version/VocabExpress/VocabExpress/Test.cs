using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace VocabExpress
{
    public partial class Test : Form
    {
        private readonly SpeechSynthesizer reader;
        private readonly TestManager testManager;

        /// <summary>
        ///     Constructs the test form
        /// </summary>
        public Test(TestManager testManager)
        {
            InitializeComponent();
            this.testManager = testManager;
            this.testManager.start();
            reader = new SpeechSynthesizer();
            nextWord();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (hasValidInput())
            {
                String input = inputTextBox.Text;
                inputTextBox.Clear();
                testManager.checkInput(input);
                nextWord();
            }
        }

        private bool hasValidInput()
        {
            if (inputTextBox.Text == "")
            {
                errorLabel.Visible = true;
                return false;
            }

            errorLabel.Visible = false;
            return true;
        }

        private void nextWord()
        {
            if (testManager.hasAnotherWord())
            {
                SpellingWord currentWord = testManager.getCurrentWord();
                pictureBox.BackgroundImage = new Bitmap(currentWord.getImage());
            }
            else
            {
                String result = testManager.getResults();
                MessageBox.Show(result, "Test Results", MessageBoxButtons.OK);
                Close();
            }
        }


        private void voiceButton_Click(object sender, EventArgs e)
        {
            SpellingWord currentWord = testManager.getCurrentWord();
            reader.SpeakAsync(currentWord.getWord());
        }
    }
}