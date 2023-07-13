namespace TextFilter
{
    /// <summary>
    /// Carries out the main body of work.
    /// </summary>
    public class TextFilterProcessor
    {
        /// <summary>
        /// List of filters that will be applied.
        /// </summary>
        private readonly List<ITextFilter> _filters;

        /// <summary>
        /// For dependency injection. Takes a list of filters.
        /// </summary>
        /// <param name="filters">List of filters</param>
        public TextFilterProcessor(List<ITextFilter> filters)
        {
            this._filters = filters;
        }

        /// <summary>
        /// Applies the filters to each word and returns those not matching and adds it to a list.
        /// List is then joined to produce the final output string.
        /// </summary>
        /// <param name="fileContents">Contents of the txt file.</param>
        /// <returns>String of the file contents without the filtered words.</returns>
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