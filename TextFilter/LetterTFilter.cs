namespace TextFilter
{
    public class LetterTFilter : ITextFilter
    {
        /// <summary>
        /// Takes a word as input and returns a boolean indicating whether the word should be filtered or not.
        /// </summary>
        /// <param name="word">Word to be checked.</param>
        /// <returns>Boolean. True = word is filtered, false = word is not filtered</returns>
        public bool Filter(string word)
        {
            if (word.Contains('T') || word.Contains('t'))
            {
                return true;
            }

            return false;
        }
    }
}