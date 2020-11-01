using RandomNumbersGame.Application.Interfaces;
using System;

namespace RandomNumbersGame.Application
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly int _minGenValue;
        private readonly int _maxGenValue;

        public RandomNumberGenerator(int minGenValue, int maxGenValue)
        {
            _minGenValue = minGenValue;
            _maxGenValue = maxGenValue;
        }

        public int GenerateRandomNumber(int? previousGeneratedNumber)
        {
            var generatedRandomNumber = new Random().Next(_minGenValue, _maxGenValue);

            if (previousGeneratedNumber == null)
                return generatedRandomNumber;

            if ((int)previousGeneratedNumber == generatedRandomNumber)
                return new Random().Next(_minGenValue, _maxGenValue);

            return generatedRandomNumber;
        }            
        
        public bool IsInputHigher(int currentValue, int input)
        {
            return input > currentValue;
        }

        public bool IsInputlower(int currentValue, int input)
        {
            return input < currentValue;
        }      
    }
}
