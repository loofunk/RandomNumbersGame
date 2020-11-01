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

        [Test]
        public void ShouldCorrectlyStateIsHigherThanInput(int input)
        {
            Assert.Fail();
        }

        [Test]
        public void ShouldCorrectlyStateIsLowerThanInput(int input)
        {
            Assert.Fail();
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