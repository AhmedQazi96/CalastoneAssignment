namespace TextFilter.Tests
{
    [TestClass]
    public class LetterTFilterTests
    {
        private LetterTFilter _letterTFilter;

        [TestInitialize]
        public void SetUp()
        {
            _letterTFilter = new LetterTFilter();
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordContainsLowercaseT()
        {
            // Arrange
            string word = "text";

            // Act
            bool result = _letterTFilter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordContainsUppercaseT()
        {
            // Arrange
            string word = "Text";

            // Act
            bool result = _letterTFilter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_WhenWordDoesNotContainLetterT()
        {
            // Arrange
            string word = "hello";

            // Act
            bool result = _letterTFilter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
