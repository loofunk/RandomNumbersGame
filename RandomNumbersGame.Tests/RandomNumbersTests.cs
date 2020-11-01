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
            _randomNumberGenerator = new RandomNumberGenerator();
        }
    
        [Test]
        public void ShouldGenerateARandomNumberBetween1and100()
        {
            // ACT
            var result = _randomNumberGenerator.GenerateRandomNumber();

            // ASSERT           
            Assert.Less(result, 100);
            Assert.Greater(result, 0);
            Assert.Greater(result, 1);
        }

        [TestCase (34, 10, false)]
        [TestCase (34, 14, false)]
        [TestCase (38, 39, true)]
        [TestCase (26, 39, true)]
        public void ShouldCorrectlyStateIsHigherThanInput(int generatedNumber, int input, bool expected)
        {   
            // ACT
            var result = _randomNumberGenerator.IsInputHigher(generatedNumber, input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestCase(34, 54, false)]
        [TestCase(34, 65, false)]
        [TestCase(38, 33, true)]
        [TestCase(26, 9, true)]
        public void ShouldCorrectlyStateIsLowerThanInput(int generatedNumber, int input, bool expected)
        {
            // ACT
            var result = _randomNumberGenerator.IsInputlower(generatedNumber, input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldEnsureGeneratedNumberIsNotEqualPreviouslyGeneratedNumber(int previousGeneratedNumber)
        {
            Assert.Fail();
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