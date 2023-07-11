using System.Text;

namespace TextFilter
{
    public class TextReader : ITextReader
    {
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