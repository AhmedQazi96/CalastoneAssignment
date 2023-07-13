using System.Text.RegularExpressions;

namespace TextFilter
{
    public class VowelInMiddleFilter : ITextFilter
    {
        /// <summary>
        /// Takes a word as input and returns a boolean indicating whether the word should be filtered or not.
        /// </summary>
        /// <param name="word">Word to be checked.</param>
        /// <returns>Boolean. True = word is filtered, false = word is not filtered</returns>
        public bool Filter(string word)
        {
            if (IsEvenLength(word))
            {
                return EvenCheck(word);
            }
            else
            {
                return OddCheck(word);
            }
        }

        /// <summary>
        /// Check if the word supplied is of even length.
        /// </summary>
        /// <param name="word">Input.</param>
        /// <returns>Boolean indicating whether the word is even or not.</returns>
        private bool IsEvenLength(string word)
        {
            int length = word.Length;
            bool isEven = length % 2 == 0;
            return isEven;
        }

        /// <summary>
        /// Gets the middle two letters and checks if they contain vowels.
        /// </summary>
        /// <param name="word">Word to be checked.</param>
        /// <returns>Boolean indicating whether the middle two characters contains a vowel/s.</returns>
        private bool EvenCheck(string word)
        {
            int length = word.Length;
            int middleIndex = length / 2;

            string middleTwoChars = word.Substring(middleIndex - 1, 2);
            
            return Regex.IsMatch(middleTwoChars, @"[aeiouAEIOU]");
        }

        /// <summary>
        /// Gets the middle letter and checks if it is a vowel.
        /// </summary>
        /// <param name="word">Word to be checked.</param>
        /// <returns>Boolean indicating whether the middle character is a vowel.</returns>
        private bool OddCheck(string word)
        {
            int length = word.Length;
            int middleIndex = length / 2;

            string middleChar = word[middleIndex].ToString();

            return Regex.IsMatch(middleChar, @"[aeiouAEIOU]");
        }
    }
}