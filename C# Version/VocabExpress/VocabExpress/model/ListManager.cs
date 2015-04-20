using System;
using System.Collections.Generic;
using VocabExpress.io;

namespace VocabExpress
{
    public class ListManager
    {
        private const String WORDS_FILE = "SpellingWords.txt";
        private readonly FileManager fileManager;
        private readonly List<SpellingWord> wordList;

        /// <summary>
        ///     Constructs a list manager
        /// </summary>
        public ListManager(FileManager fileManager)
        {
            this.fileManager = fileManager;
            this.fileManager.readInFile(WORDS_FILE);
            wordList = this.fileManager.getWordList();
        }

        /// <summary>
        ///     Adds a spelling word  to the manager
        /// </summary>
        /// <param name="word">A SpellingWord</param>
        public void addWord(SpellingWord word)
        {
            wordList.Add(word);
        }

        /// <summary>
        ///     Removes a word from the list manager
        /// </summary>
        /// <param name="word">A SpellingWords</param>
        public void removeWord(SpellingWord word)
        {
            wordList.Remove(word);
        }

        /// <summary>
        ///     Removes a word from the list manager
        /// </summary>
        /// <param name="text">A SpellingWords</param>
        public void removeWord(String text)
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                SpellingWord currWord = wordList[i];
                String word = currWord.getWord();

                if (word.Equals(text))
                {
                    wordList.Remove(currWord);
                }
            }
        }

        /// <summary>
        ///     Clears the list manager of all words
        /// </summary>
        public void clearAll()
        {
            wordList.Clear();
        }

        /// <summary>
        ///     Returns a collection of spelling words
        /// </summary>
        /// <returns>A list of spelling word</returns>
        public List<SpellingWord> getSpellingWords()
        {
            return wordList;
        }

        /// <summary>
        ///     Save the list
        /// </summary>
        public void saveWords()
        {
            fileManager.writeToFile(WORDS_FILE, wordList);
        }
    }
}