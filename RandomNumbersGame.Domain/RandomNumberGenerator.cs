using RandomNumbersGame.Application.Interfaces;
using System;

namespace RandomNumbersGame.Application
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public RandomNumberGenerator()
        {
        }

        public int GenerateRandomNumber()
        {
            return new Random().Next(1, 100);
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
