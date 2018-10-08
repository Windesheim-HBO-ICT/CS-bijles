//using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringCalculator.Calculator;
using NUnit.Framework;
using System;

namespace SimpleStringCalculator.UnitTests
{
//Happy path
    [TestFixture]//[TestClass]
    public class StringCalculatorTests
    {
        [Test]//[TestMethod]
        public void Add_ThreeNumbers_ReturnsSum()
        {
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result = 0;
            //Act
            result = calculator.Add("1,2,3");
            //Assert
            Assert.AreEqual(6, result);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("2,4,6,8", 20)]
        [TestCase("400", 400)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", 55)]
        public void Add_Numbers_ReturnsSum(string input, int result)
        {
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int answer = 0;
            //Act
            answer = calculator.Add(input);
            //Assert
            Assert.AreEqual(result, answer);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("2,4,6,8", 384)]
        [TestCase("400", 400)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", 3628800)]
        public void Mul_Numbers_ReturnsSum(string input, int result)
        {
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int answer = 0;
            //Act
            answer = calculator.Mul(input);
            //Assert
            Assert.AreEqual(result, answer);
        }

//Unhappy Path
        [TestCase(null, 0)]
        [TestCase("", 0)]
        public void Add_EmptyString_ReturnsNull(string input, int result)
        {
            //Arrange
            StringCalculator calculator = new StringCalculator();
            //Act
            int answer = calculator.Add(input);
            //Assert
            Assert.AreEqual(result, answer);
        }

        [TestCase("this is invalid", typeof(ArgumentException))]
        [TestCase("a,1", typeof(ArgumentException))]
        public void Add_InvalidArgument_ReturnsException(string arg, Type expectedException)
        {
            StringCalculator calculator = new StringCalculator();
            Assert.Throws(expectedException, () => calculator.Add(arg));
        }
    }
}
