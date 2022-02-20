using Microsoft.AspNetCore.Mvc;
using ZimbabweCalendar.API.Models;
using ZimbabweCalendar.API.Models.Local;
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

        [HttpPost]
        public async Task<IActionResult> Add(PublicHolidayRequest request)
        {
            var result = await _repository.AddHolidayAsync(new PublicHoliday
            {
                Title = request.Title,
                Description = request.Description,
                Date = request.Date
            });

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHolidays()
        {
            var holidays = await _repository.GetAllAsync();
            return Ok(holidays);
        }
    }
}