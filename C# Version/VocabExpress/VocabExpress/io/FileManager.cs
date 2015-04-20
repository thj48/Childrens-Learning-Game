using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VocabExpress.io
{
    public class FileManager
    {
        private readonly char[] delimiterChars = {','};
        private String[] lines;

        public void readInFile(String fileName)
        {
            lines = File.ReadAllLines(fileName);
        }

        public void writeToFile(String fileName, String text)
        {
            File.WriteAllText(fileName, text);
        }

        public void writeToFile(String fileName, List<SpellingWord> list)
        {
            String text = formatInfoToSave(list);
            File.WriteAllText(fileName, text);
        }

        public List<SpellingWord> getWordList()
        {
            var list = new List<SpellingWord>();

            foreach (String line in lines)
            {
                String[] words = line.Split(delimiterChars);
                var spellingWord = new SpellingWord(words[0], words[1]);
                list.Add(spellingWord);
            }

            return list;
        }

        public String getResults()
        {
            String result = "";

            foreach (String line in lines)
            {
                result += line + "\r\n";
            }

            if (!lines.Any())
            {
                result = "No test taken yet";
            }

            return result;
        }

        private string formatInfoToSave(List<SpellingWord> list)
        {
            String words = "";

            for (int i = 0; i < list.Count; i++)
            {
                SpellingWord currWord = list[i];
                words += currWord.getWord() + "," + currWord.getImage() + "\r\n";
            }

            return words;
        }
    }
}