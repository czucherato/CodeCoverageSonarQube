using Xunit;
using System;

namespace Math.Test
{
    public class MathTest
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(5, 6, 11)]
        public void AddTest(int firstValue, int secondValue, int expected)
        {
            // Arrange
            SimpleMath math = new SimpleMath();

            // Act
            int actual = math.Add(firstValue, secondValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(7, 8, -1)]
        public void SobtractTest(int firstValue, int secondValue, int expected)
        {
            // Arrange
            SimpleMath math = new SimpleMath();

            // Act
            int actual = math.Subtract(firstValue, secondValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivideTest(int firstValue, int secondValue, int expected)
        {
            // Arrange
            SimpleMath math = new SimpleMath();

            // Act
            decimal actual = math.Divide(firstValue, secondValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTest_ThrowsException()
        {
            // Arrange
            SimpleMath math = new SimpleMath();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
        }
    }
}