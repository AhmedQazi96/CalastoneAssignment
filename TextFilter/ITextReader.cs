namespace TextFilter
{
    /// <summary>
    /// Defines a contract for reading a txt file.
    /// </summary>
    public interface ITextReader
    {
        /// <summary>
        /// Reads the txt file.
        /// </summary>
        /// <param name="absoluteFilePath">The absolute file path of the file to be read.</param>
        /// <returns>The file contents as a string.</returns>
        string ReadText(string absoluteFilePath);
    }
}