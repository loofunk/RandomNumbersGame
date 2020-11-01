﻿using RandomNumbersGame.Application.Enums;
using RandomNumbersGame.Application.Interfaces;
using System;

namespace RandomNumbersGame.Application
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly int _minGenValue;
        private readonly int _maxGenValue;
        private int _totalPoints;

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

        public void ApplyUserGuess(Guess userGuess, int previousGenNumber, int newGenNumber)
        {
            if (userGuess == Guess.Higher)
            {
                if (IsInputHigher(previousGenNumber, newGenNumber))
                    _totalPoints = 1;
            }

            if (userGuess == Guess.Lower)
            {
                if (IsInputlower(previousGenNumber, newGenNumber))
                    _totalPoints = 0;
            }
        }

        public int GetTotalPoints()
        {
            return _totalPoints;
        }
    }
}