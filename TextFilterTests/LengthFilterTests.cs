namespace TextFilter.Tests
{
    [TestClass]
    public class LengthFilterTests
    {
        private LengthFilter _lengthFilter;

        [TestInitialize]
        public void SetUp()
        {
            _lengthFilter = new LengthFilter();
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordLengthIsLessThanThree()
        {
            // Arrange
            string word = "Hi";

            // Act
            bool result = _lengthFilter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_WhenWordLengthIsEqualToThree()
        {
            // Arrange
            string word = "Hey";

            // Act
            bool result = _lengthFilter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_WhenWordLengthIsGreaterThanThree()
        {
            // Arrange
            string word = "Hello";

            // Act
            bool result = _lengthFilter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}