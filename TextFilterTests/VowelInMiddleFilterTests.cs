namespace TextFilter.Tests
{
    [TestClass]
    public class VowelInMiddleFilterTests
    {
        private VowelInMiddleFilter _vowelInMiddleFilter;

        [TestInitialize]
        public void SetUp()
        {
            _vowelInMiddleFilter = new VowelInMiddleFilter();
        }

        [TestMethod]
        public void Filter_ReturnsTrue_ForEvenWordAndMiddleVowel()
        {
            // Arrange
            string word = "what";

            // Act
            bool result = _vowelInMiddleFilter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_EvenWordAndMiddleNotVowel()
        {
            // Arrange
            string word = "rather";

            // Act
            bool result = _vowelInMiddleFilter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Filter_ReturnsTrue_ForOddWordAndMiddleVowel()
        {
            // Arrange
            string word = "clean";

            // Act
            bool result = _vowelInMiddleFilter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_ForOddWordAndMiddleNotVowel()
        {
            // Arrange
            string word = "the";

            // Act
            bool result = _vowelInMiddleFilter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
