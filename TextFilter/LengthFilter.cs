namespace TextFilter
{
    public class LengthFilter : ITextFilter
    {
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