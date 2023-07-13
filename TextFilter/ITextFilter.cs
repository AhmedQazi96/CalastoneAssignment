namespace TextFilter
{
    /// <summary>
    /// Defines a contract for the filtering functionality.
    /// Classes that implement this interface will provide their own implementation of the Filter method.
    /// </summary>
    public interface ITextFilter
    {
        bool Filter(string word);
    }
}