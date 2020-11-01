using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomNumbersGame.Application.Interfaces;

namespace RandomNumbersGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumbersController : ControllerBase
    {        
        private readonly ILogger<RandomNumbersController> _logger;
        private readonly IRandomNumberGenerator _randomNumberGenerator;

        public RandomNumbersController(IRandomNumberGenerator randomNumberGenerator, 
            ILogger<RandomNumbersController> logger)
        {
            _logger = logger;
            _randomNumberGenerator = randomNumberGenerator;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            return 0;
        }
    }
}
