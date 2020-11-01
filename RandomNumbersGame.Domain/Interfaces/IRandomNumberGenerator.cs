using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbersGame.Application.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int GenerateRandomNumber();

        bool IsInputHigher(int currentValue, int input);

        bool IsInputlower(int currentValue, int input);
    }
}
