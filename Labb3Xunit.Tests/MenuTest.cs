using System;
using Xunit;
using Labb3Xunit;
using System.Collections.Generic;

namespace Labb3XunitTests
{
    public class MenuTest
    {
        [Fact]
        public void PrintAllCalculations_Should_Return_Positive_If_List_Is_Not_Empty()
        {
            //Arrange
            Menu m1 = new Menu();
            m1.Calculations = new List<string>();
            m1.Calculations.Add("10 + 5 = 25");
            bool expected = true;

            //Act
            bool actual = m1.PrintAllCalculations();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrintAllCalculations_Should_Return_Negative_If_List_Is_Empty()
        {
            //Arrange
            Menu m1 = new Menu();
            m1.Calculations = new List<string>();
            bool expected = false;

            //Act
            bool actual = m1.PrintAllCalculations();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
