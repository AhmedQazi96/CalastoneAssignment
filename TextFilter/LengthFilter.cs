namespace TextFilter
{
    public class LengthFilter : ITextFilter
    {
        /// <summary>
        /// Takes a word as input and returns a boolean indicating whether the word should be filtered or not.
        /// </summary>
        /// <param name="word">Word to be checked.</param>
        /// <returns>Boolean. True = word is filtered, false = word is not filtered</returns>
        public bool Filter(string word)
        {
            if (word.Length < 3)
            {
                return true;
            }

            return false;
        }
    }
}