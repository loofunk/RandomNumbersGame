﻿using RandomNumbersGame.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbersGame.Application.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int TotalPoints { get; set; }
        int GenerateRandomNumber(int? previousGeneratedNumber);

        bool IsInputHigher(int currentValue, int input);

        bool IsInputlower(int currentValue, int input);

        void ApplyUserGuess(Guess userGuess, int previousGenNumber, int newGenNumber);

        bool IsGameOver();
    }
}
