namespace TextFilter
{
    public class LetterTFilter : ITextFilter
    {
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