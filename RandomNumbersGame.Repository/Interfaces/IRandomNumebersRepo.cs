using RandomNumbersGame.Repository.Model;
using System;
using System.Collections.Generic;

namespace RandomNumbersGame.Repository
{
    public interface IRandomNumbersRepository
    {
        void AddHighScore(UserHighScore highScore);

        List<UserHighScore> GetHighScores();

        int GetHighestScoreByUser(string name);
    }
}