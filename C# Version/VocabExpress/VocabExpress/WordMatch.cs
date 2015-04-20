using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VocabExpress
{
    public partial class WordMatch : Form
    {
        private readonly List<SpellingWord> list;
        private SpellingWord currentWord;
        private String selectedWord;

        /// <summary>
        ///     Constructs the word match form
        /// </summary>
        public WordMatch(ListManager listManager)
        {
            InitializeComponent();
            list = listManager.getSpellingWords();
            nextWord();
            selectWord();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextWord();
            selectWord();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkIfCorrect((string) pictureBox1.Tag);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkIfCorrect((string) pictureBox2.Tag);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkIfCorrect((string) pictureBox3.Tag);
        }

        private void checkIfCorrect(String text)
        {
            resultLabel.Visible = true;

            if (selectedWord.Equals(text))
            {
                nextButton.Enabled = true;
                resultLabel.Text = "Correct!!";
            }
            else
            {
                nextButton.Enabled = false;
                resultLabel.Text = "Incorrect!!";
            }
        }

        private void setPictureBoxes(int index, int selection)
        {
            currentWord = list[index];
            PictureBox picturebox;

            switch (selection)
            {
                case 0:
                    picturebox = pictureBox1;
                    break;

                case 1:
                    picturebox = pictureBox2;
                    break;

                case 2:
                    picturebox = pictureBox3;
                    break;

                default:
                    picturebox = null;
                    break;
            }

            picturebox.BackgroundImage = new Bitmap(currentWord.getImage());
            picturebox.Tag = currentWord.getWord();
        }

        /// <summary>
        ///     Finds the next word
        /// </summary>
        public void nextWord()
        {
            resultLabel.Visible = false;

            for (int i = 0; i < 3; i++)
            {
                var random = new Random();
                int number = random.Next(0, list.Count);

                setPictureBoxes(number, i);
            }
        }

        /// <summary>
        ///     Chooses the word
        /// </summary>
        public void selectWord()
        {
            var random = new Random();
            int number = random.Next(0, 3);
            String word;

            switch (number)
            {
                case 0:
                    word = (String) pictureBox1.Tag;
                    break;

                case 1:
                    word = (String) pictureBox2.Tag;
                    break;

                case 2:
                    word = (String) pictureBox3.Tag;
                    break;

                default:
                    word = "";
                    break;
            }

            wordLabel.Text = word;
            selectedWord = word;
        }
    }
}