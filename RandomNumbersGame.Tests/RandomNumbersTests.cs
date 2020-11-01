using NUnit.Framework;
using RandomNumbersGame.Application;
using RandomNumbersGame.Application.Enums;
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

        [TestCase(1, 30, Guess.Higher, 1)]
        [TestCase(1, 12, Guess.Higher, 1)]
        [TestCase(1, 12, Guess.Lower, 0)]
        [TestCase(25,99, Guess.Lower, 0)]
        public void WhenUserMakesAGuessShouldReturnCorrectResult(int firstGenValue, int secondGenValue,
            Guess userGuess, int expectedPoints)
        {
            // ACT
             _randomNumberGenerator.ApplyUserGuess(userGuess, firstGenValue, secondGenValue);
            var result = _randomNumberGenerator.GetTotalPoints();

            // ASSERT
            Assert.AreEqual(expectedPoints, result);
        }


        [TestCase(3, 3)]
        [TestCase(7, 7)]
        public void GivenASetOfGuessesShouldSetTotalPointsToCorrectValue(int numberOfHigherGuesses, 
            int expectedTotalPoints)
        {
            // ARRANGE            
            while (numberOfHigherGuesses > 0)
            {
                _randomNumberGenerator.ApplyUserGuess(Guess.Higher, 1, 22);   
                numberOfHigherGuesses--;
            }

            // ACT
            var result = _randomNumberGenerator.GetTotalPoints();

            // ASSERT
            Assert.AreEqual(expectedTotalPoints, result);
            Assert.IsFalse(_randomNumberGenerator.IsGameOver());
        }

        [TestCase(3, 0)]
        [TestCase(7, 0)]
        public void GivenASetOfLowerShouldSetTotalPointsToCorrectValue(int numberOfLowerGuesses,
            int expectedTotalPoints)
        {
            // ARRANGE            
            while (numberOfLowerGuesses > 0)
            {
                _randomNumberGenerator.ApplyUserGuess(Guess.Lower, 18, 2);
                numberOfLowerGuesses--;
            }

            // ACT
            var result = _randomNumberGenerator.GetTotalPoints();

            // ASSERT
            Assert.AreEqual(expectedTotalPoints, result);
            Assert.IsTrue(_randomNumberGenerator.IsGameOver());
        }


        [Test]
        public void GivenMaximumPointsSetOfPointsShouldSetGameToFinished(int input)
        {
            Assert.Fail();
        }
    }
}