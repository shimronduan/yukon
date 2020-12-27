using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;

namespace timetable.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPeriodRepository _periodRepository;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPeriodRepository periodRepository)
        {
            _logger = logger;
            _periodRepository = periodRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rng = new Random();
            return Ok();
        }
        
    }
}
