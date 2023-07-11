namespace TextFilterTests
{
    [TestClass]
    public class TextReaderTests
    {
        [TestMethod]
        public void ReadText_FileFound_ReturnsExpectedString()
        {
            // Arrange
            var textReader = new TextFilter.TextReader();
            string currentDirectory = Directory.GetCurrentDirectory();
            string relativeFilePath = $"TestTexts\\TestInputText.txt";
            string absoluteFilePath = Path.Combine(currentDirectory, relativeFilePath);

            // Act
            string result = textReader.ReadText(absoluteFilePath);

            // Assert
            Assert.AreEqual("Line 1\r\nLine 2\r\n", result);
        }

        [TestMethod]
        public void ReadText_FileNotFound_HandleExceptionAndReturnAnEmptyString()
        {
            // Arrange
            var textReader = new TextFilter.TextReader();
            string currentDirectory = Directory.GetCurrentDirectory();
            string relativeFilePath = $"TestTexts\\x.txt";
            string absoluteFilePath = Path.Combine(currentDirectory, relativeFilePath);

            // Act
            string result = textReader.ReadText(absoluteFilePath);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}