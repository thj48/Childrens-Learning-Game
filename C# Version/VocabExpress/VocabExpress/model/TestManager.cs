using System;
using System.Collections.Generic;
using VocabExpress.io;

namespace VocabExpress
{
    public class TestManager
    {
        private const String REPORT_FILE = "Report.txt";
        private readonly FileManager fileManager;
        private readonly ListManager listManager;
        private SpellingWord currentWord;
        private List<SpellingWord> randomWordList;
        private String result;
        private int wordPosition;
        private int wordsCorrect;
        private List<String> wordsMissed;

        /// <summary>
        ///     Constructs a TestManager
        /// </summary>
        /// <param name="fileManager">A filemanager</param>
        /// <param name="listManager">A list manager</param>
        public TestManager(ListManager listManager, FileManager fileManager)
        {
            this.listManager = listManager;
            this.fileManager = fileManager;
        }

        /// <summary>
        ///     Initiates the values
        /// </summary>
        public void start()
        {
            randomWordList = getRandomizedList(listManager.getSpellingWords());
            wordsMissed = new List<String>();
            wordsCorrect = 0;
            wordPosition = 0;
        }

        /// <summary>
        ///     Returns if the input is correct
        /// </summary>
        /// <param name="input">a string representation of the users spelling of the word</param>
        public void checkInput(String input)
        {
            if (input == currentWord.getWord())
            {
                wordsCorrect++;
            }
            else
            {
                String wordMissedOutput = currentWord.getWord() + " -> " + input;
                wordsMissed.Add(wordMissedOutput);
            }
        }


        private List<SpellingWord> getRandomizedList(List<SpellingWord> list)
        {
            var wordList = new List<SpellingWord>(list);
            var randomList = new List<SpellingWord>();
            var rand = new Random();

            while (wordList.Count > 0)
            {
                int randomIndex = rand.Next(0, wordList.Count);
                randomList.Add(wordList[randomIndex]);
                wordList.RemoveAt(randomIndex);
            }

            return randomList;
        }

        /// <summary>
        ///     Returns if theres another word avaliable
        /// </summary>
        /// <returns>True or false depending if theres another word</returns>
        public Boolean hasAnotherWord()
        {
            if (wordPosition < randomWordList.Count)
            {
                currentWord = randomWordList[wordPosition];

                wordPosition++;
                return true;
            }
            saveResults();
            return false;
        }

        private void computeScore()
        {
            double score = getScore();

            result = "Score: " + score + "%\r\rWords Missed -> InputSpelling\r\r";

            if (wordsMissed.Count > 0)
            {
                foreach (String current in wordsMissed)
                {
                    result += current + "\r";
                }
            }
            else
            {
                result += "none";
            }
        }

        private void saveResults()
        {
            computeScore();
            fileManager.writeToFile(REPORT_FILE, result);
        }

        /// <summary>
        ///     Returns a string representation of the results
        /// </summary>
        public String getResults()
        {
            return result;
        }

        /// <summary>
        ///     Returns the current spelling word
        /// </summary>
        /// <returns>The current spellingWord</returns>
        public SpellingWord getCurrentWord()
        {
            return currentWord;
        }

        private double getScore()
        {
            double rawScore = (double) wordsCorrect/randomWordList.Count*100;
            return Math.Round(rawScore, 1);
        }
    }
}