using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbersGame.Repository.Model
{
    public class UserHighScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
