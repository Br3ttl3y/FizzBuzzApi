using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FizzBuzzApi;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        [TestMethod]
        public void TestClassic()
        {
            // Act
            List<string> results = FizzBuzz.Classic();

            // Assert
            Assert.AreEqual("3: Fizz", results[2]);
            Assert.AreEqual("5: Buzz", results[4]);
            Assert.AreEqual("15: FizzBuzz", results[14]);
        }

        [TestMethod]
        public void TestCustomStartAndEnd()
        {
            // Arrange
            int start = 1;
            int end = 15;

            // Act
            List<string> results = FizzBuzz.CustomStartAndEnd(start, end);

            // Assert
            Assert.AreEqual("3: Fizz", results[2]);
            Assert.AreEqual("5: Buzz", results[4]);
            Assert.AreEqual("15: FizzBuzz", results[14]);
        }

        [TestMethod]
        public void TestCustomWithClassicRules()
        {
            // Arrange
            FizzBuzzConfig config = new FizzBuzzConfig
            {
                Start = 1,
                End = 100,
                Words = new Dictionary<int, string> { { 3, "Fizz"}, { 5, "Buzz"} }
            };

            // Act
            List<string> results = FizzBuzz.CustomConfig(config);

            // Assert
            Assert.AreEqual("3: Fizz", results[2]);
            Assert.AreEqual("5: Buzz", results[4]);
            Assert.AreEqual("15: FizzBuzz", results[14]);
        }

        [TestMethod]
        public void TestCustomWithCustomGame()
        {
            // Arrange
            FizzBuzzConfig config = new FizzBuzzConfig
            {
                Start = 1,
                End = 20,
                Words = new Dictionary<int, string> { { 2, "Fizz"}, { 3, "Buzz" }, { 4, "Bazz" } }
            };

            // Act
            List<string> results = FizzBuzz.CustomConfig(config);

            // Assert
            Assert.AreEqual("2: Fizz", results[1]);
            Assert.AreEqual("3: Buzz", results[2]);
            Assert.AreEqual("4: FizzBazz", results[3]);
            Assert.AreEqual("6: FizzBuzz", results[5]);
            Assert.AreEqual("12: FizzBuzzBazz", results[11]);
        }
    }
}
