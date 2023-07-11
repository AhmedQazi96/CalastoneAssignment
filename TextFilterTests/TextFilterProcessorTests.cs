using Moq;

namespace TextFilter.Tests
{
    [TestClass]
    public class TextFilterProcessorTests
    {
        [TestMethod]
        public void ApplyFilters_ShouldFilterWordsBasedOnProvidedFilters()
        {
            // Arrange
            var lengthFilter = new Mock<ITextFilter>();
            lengthFilter.Setup(f => f.Filter(It.IsAny<string>())).Returns<string>(word => word.Length > 3);

            var letterTFilter = new Mock<ITextFilter>();
            letterTFilter.Setup(f => f.Filter(It.IsAny<string>())).Returns<string>(word => word.Contains("T") || word.Contains("t"));

            var filters = new List<ITextFilter>
            {
                lengthFilter.Object,
                letterTFilter.Object
            };

            var filterProcessor = new TextFilterProcessor(filters);
            string fileContents = "It is a period of civil war.";

            // Act
            string result = filterProcessor.ApplyFilters(fileContents);

            // Assert
            Assert.AreEqual("is a of", result);
        }

        [TestMethod]
        public void ApplyFilters_ShouldReturnOriginalTextWhenNoFiltersMatch()
        {
            // Arrange
            var filters = new List<ITextFilter>
            {
                new Mock<ITextFilter>().Object,
                new Mock<ITextFilter>().Object
            };

            var filterProcessor = new TextFilterProcessor(filters);
            string fileContents = "Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire.";

            // Act
            string result = filterProcessor.ApplyFilters(fileContents);

            // Assert
            Assert.AreEqual(fileContents, result);
        }
    }
}