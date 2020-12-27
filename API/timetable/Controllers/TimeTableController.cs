using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace timetable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTableController : ControllerBase
    {
        private readonly IPeriodService _periodService;
        private readonly ILogger<TimeTableController> _logger;

        public TimeTableController(ILogger<TimeTableController> logger, IPeriodService periodService)
        {
            _logger = logger;
            _periodService = periodService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var timeTable = _periodService.GetAllPeriodsAsync();
            return Ok(JsonSerializer.Serialize(timeTable));
        }
    }
}
