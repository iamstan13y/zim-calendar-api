using Microsoft.AspNetCore.Mvc;
using ZimbabweCalendar.API.Models;
using ZimbabweCalendar.API.Models.Repository;

namespace ZimbabweCalendar.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HolidaysController : ControllerBase
    {
        private readonly IHolidayRepository _repository;

        public HolidaysController(IHolidayRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("get-all-holidays")]
        [ProducesResponseType(typeof(IEnumerable<PublicHoliday>), 200)]
        public async Task<IActionResult> GetAllHolidays()
        {
            var holidays = await _repository.GetAllAsync();
            return Ok(holidays);
        }

        [HttpGet("get-by-month/{monthId}")]
        [ProducesResponseType(typeof(IEnumerable<PublicHoliday>), 200)]
        public async Task<IActionResult> GetHolidaysByMonth(int monthId)
        {
            var holidays = await _repository.GetByMonthAsync(monthId);
            return Ok(holidays);
        }
    }
}