using System;

namespace VocabExpress
{
    public class SpellingWord
    {
        private readonly String image;
        private readonly String word;

        /// <summary>
        ///     Constructs the spelling word
        /// </summary>
        /// <param name="word">a string repesentation of the word</param>
        /// <param name="image">a string representation of where the image exists</param>
        public SpellingWord(string word, string image)
        {
            this.word = word;
            this.image = image;
        }

        /// <summary>
        ///     Returns the word
        /// </summary>
        /// <returns>A string representation of the the word</returns>
        /// >
        public String getWord()
        {
            return word;
        }

        /// <summary>
        ///     Returns the image
        /// </summary>
        /// <returns>A string representation of the image</returns>
        /// >
        public String getImage()
        {
            return image;
        }
    }
}