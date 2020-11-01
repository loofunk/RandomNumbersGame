using RandomNumbersGame.Repository.Model;
using System;
using System.Collections.Generic;

namespace RandomNumbersGame.Repository
{
    public class RandomNumbersRepository : IRandomNumbersRepository
    {
        public void AddHighScore(UserHighScore highScore)
        {
            throw new NotImplementedException();
        }

        public int GetHighestScoreByUser(string name)
        {
            throw new NotImplementedException();
        }

        public List<UserHighScore> GetHighScores()
        {
            throw new NotImplementedException();
        }
    }
}
