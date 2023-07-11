namespace TextFilter
{
    public class TextFilterProcessor : ITextFilterProcessor
    {
        private readonly List<ITextFilter> _filters;
        public TextFilterProcessor(List<ITextFilter> filters)
        {
            this._filters = filters;
        }
        public string ApplyFilters(string fileContents)
        {
            string[] words = fileContents.Split(' ');

            List<string> filteredWords = new List<string>();

            foreach (string word in words)
            {
                if (!_filters.Any(filter => filter.Filter(word)))
                {
                    filteredWords.Add(word);
                }
            }

            string filteredText = string.Join(" ", filteredWords);
            return filteredText;
        }
    }
}