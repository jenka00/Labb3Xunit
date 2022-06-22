using System;
using Xunit;
using Labb3Xunit;

namespace Labb3XunitTests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(8.12, 35.2, 43.32)]
        [InlineData(double.MaxValue, 2, double.MaxValue)]
        public void Add_Should_Return_Positive_When_Using_Positive_Numbers(double x, double y, double expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Should_Return_Negative_When_Using_Negative_Numbers()
        {
            //Arrange
            Calculator cal = new Calculator();
            double x = -6;
            double y = -8;
            double expected = -14;

            //Act
            double actual = cal.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(25, 4, 21)]
        [InlineData(48, -2, 50)]
        [InlineData(double.MinValue, 10, double.MinValue)]
        public void Subtract_Should_Return_Positive_When_First_Number_Is_Positive_And_The_Greatest(double x, double y, double expected)
        {
            //Arrange
            Calculator cal = new Calculator();
            
            //Act
            double actual = cal.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(-40, -9, -31, true)]
        [InlineData(-5, -7, -10, false)]
        [InlineData(-1, 1, 0, false)]
        [InlineData(-82, double.MaxValue, double.MinValue, true)]
        public void Subtract_Should_Return_Negative_When_Both_Numbers_Are_Negative_But_The_First_Is_The_Smallest(double x, double y, double sum, bool expectedResult)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Subtract(x, y);
    
            //Assert
            Assert.Equal(expectedResult, actual == sum);
        }
        [Fact]
        public void Multiply_Should_Return_Positive_When_Using_Positive_Numbers()
        {
            //Arrange
            Calculator cal = new Calculator();
            double x = 3;
            double y = 5;
            double expected = 15;
            double notExpected = -15;

            //Act
            double actual = cal.Multiply(x, y);

            //Assert
            Assert.True(actual == expected);
            Assert.False(actual == notExpected);
        }
        [Theory]
        [InlineData(-6, 8, -48, true)]
        [InlineData(-6, -8, -48, false)]
        [InlineData(9, -8, -72, true)]
        [InlineData(-5, 0, -5, false)]
        public void Multiply_Should_Return_Negative_When_Using_Negative_Numbers(double x, double y, double product, bool expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual == product);
        }
        [Theory]
        [InlineData(100, 5, 20)]
        [InlineData(5, 2, 2.5)]
        public void Divide_Should_Return_Positive_When_Using_Positive_Numbers(double x, double y, double expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Divide(x, y);

            //Assert
            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(-8, 2, -4)]
        [InlineData(30, -2.5, -12)]
        public void Divide_Should_Return_Negative_When_Using_Negative_Number(double x, double y, double expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Divide(x, y);

            //Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Divide_Should_Return_Zero_If_Dividing_By_Zero()
        {
            //Arrange
            Calculator cal = new Calculator();
            double expected = 0;

            //Act
            double actual = cal.Divide(10, 0);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
