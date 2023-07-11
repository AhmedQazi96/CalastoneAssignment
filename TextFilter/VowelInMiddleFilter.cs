using System.Text.RegularExpressions;

namespace TextFilter
{
    public class VowelInMiddleFilter : ITextFilter
    {
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

        private bool IsEvenLength(string word)
        {
            int length = word.Length;
            bool isEven = length % 2 == 0;
            return isEven;
        }

        private bool EvenCheck(string word)
        {
            int length = word.Length;
            int middleIndex = length / 2;

            string middleTwoChars = word.Substring(middleIndex - 1, 2);
            
            return Regex.IsMatch(middleTwoChars, @"[aeiouAEIOU]");
        }

        private bool OddCheck(string word)
        {
            int length = word.Length;
            int middleIndex = length / 2;

            string middleChar = word[middleIndex].ToString();

            return Regex.IsMatch(middleChar, @"[aeiouAEIOU]");
        }
    }
}