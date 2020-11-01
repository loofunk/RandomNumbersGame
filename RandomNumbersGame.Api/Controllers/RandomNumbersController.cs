using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandomNumbersGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumbersController : ControllerBase
    {        
        private readonly ILogger<RandomNumbersController> _logger;

        public RandomNumbersController(ILogger<RandomNumbersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            return 0;
        }
    }
}
