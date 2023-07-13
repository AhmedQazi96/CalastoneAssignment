using System.Text;

namespace TextFilter
{
    public class TextReader : ITextReader
    {
        /// <summary>
        /// Reads the text file.
        /// </summary>
        /// <param name="absoluteFilePath">Takes the absolute file path as a parameter.</param>
        /// <returns>Returns the file contents as a string.</returns>
        public string ReadText(string absoluteFilePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                using (StreamReader sr = new StreamReader(absoluteFilePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }

                return sb.ToString();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An I/O error occurred: " + ex.Message);
            }

            return string.Empty;
        }
    }
}