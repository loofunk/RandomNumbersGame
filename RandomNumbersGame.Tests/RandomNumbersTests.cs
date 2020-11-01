using NUnit.Framework;
using RandomNumbersGame.Application;
using RandomNumbersGame.Application.Interfaces;

namespace RandomNumbersGame.Tests
{
    public class RandomNumbersTests
    {
        private IRandomNumberGenerator _randomNumberGenerator;

        [SetUp]
        public void Setup()
        {
            _randomNumberGenerator = new RandomNumberGenerator(1, 100);
        }
    
        [Test]
        public void ShouldGenerateARandomNumberBetween1and100()
        {
            // ACT
            var result = _randomNumberGenerator.GenerateRandomNumber(null);

            // ASSERT           
            Assert.Less(result, 100);
            Assert.Greater(result, 0);
            Assert.Greater(result, 1);
        }

        [TestCase (34, 10, false)]
        [TestCase (34, 14, false)]
        [TestCase (38, 39, true)]
        [TestCase (26, 39, true)]
        public void ShouldCorrectlyStateIsHigherThanInput(int previousGenNumber, int newGenNumber, bool expected)
        {   
            // ACT
            var result = _randomNumberGenerator.IsInputHigher(previousGenNumber, newGenNumber);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestCase(34, 54, false)]
        [TestCase(34, 65, false)]
        [TestCase(38, 33, true)]
        [TestCase(26, 9, true)]
        public void ShouldCorrectlyStateIsLowerThanInput(int previousGenNumber, int newGenNumber, bool expected)
        {
            // ACT
            var result = _randomNumberGenerator.IsInputlower(previousGenNumber, newGenNumber);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldEnsureGeneratedNumberIsNotEqualPreviouslyGeneratedNumber()
        {   
            // ACT
            var firstGenValue = _randomNumberGenerator.GenerateRandomNumber(null);
            var secondGenValue = _randomNumberGenerator.GenerateRandomNumber(firstGenValue);

            // ASSERT
            Assert.AreNotEqual(firstGenValue, secondGenValue);
        }

        [Test]
        public void ShouldCorrectlyShowIfCorrectInput(int input)
        {
            Assert.Fail();
        }

        [Test]
        public void GivenInputShouldReturnCorrectAmountOfPoints(int input)
        {
            Assert.Fail();
        }

        [Test]
        public void GivenMaximumPointsSetOfPointsShouldSetGameToFinished(int input)
        {
            Assert.Fail();
        }
    }
}