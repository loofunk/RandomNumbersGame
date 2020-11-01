using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomNumbersGame.Application.Enums;
using RandomNumbersGame.Application.Interfaces;
using RandomNumbersGame.Web.Models;

namespace RandomNumbersGame.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRandomNumberGenerator _randomNumberGenerator;

        public HomeController(ILogger<HomeController> logger, IRandomNumberGenerator randomNumberGenerator)
        {
            _logger = logger;
            _randomNumberGenerator = randomNumberGenerator;
        }

        public IActionResult Index()
        {
            var model = new UserInputModel
            {
                CurrentValue = _randomNumberGenerator.GenerateRandomNumber(null)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(UserInputModel model)
        {
            Guess userguess;

            if (model.IsHigher)
                userguess = Guess.Higher;
            else
                userguess = Guess.Lower;
                        
            _randomNumberGenerator.TotalPoints = model.Points;

            var newGenNumber = _randomNumberGenerator.GenerateRandomNumber(model.CurrentValue);
            _randomNumberGenerator.ApplyUserGuess(userguess, model.CurrentValue, newGenNumber);
                        
            model.IsGameOver = _randomNumberGenerator.IsGameOver();

            if (model.IsGameOver)
                model.CurrentValue = _randomNumberGenerator.GenerateRandomNumber(null);

            model.Points = _randomNumberGenerator.TotalPoints;            

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
