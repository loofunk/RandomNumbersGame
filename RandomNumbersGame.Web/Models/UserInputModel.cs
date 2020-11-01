using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumbersGame.Web.Models
{
    public class UserInputModel
    {
        public bool IsHigher { get { return HigherLower == "higher";  } }
        public bool IsLower { get { return HigherLower == "lower"; } }

        [Required]
        public string HigherLower { get; set; }
        
        public int CurrentValue { get; set; }
        public bool IsGameOver { get; set; }
    }
}
