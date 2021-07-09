using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Planner.Models;
using Planner.Services;

namespace Planner.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayController : ControllerBase
    {
        private readonly IDayService _dayService;
        

        public DayController(IDayService dayService)
        {
            _dayService = dayService;
        }

        [HttpGet]
        public DayDto GetDay()
        {
            var date = DateTime.Today;
            return _dayService.GetDay(date);
        }
    }
}
