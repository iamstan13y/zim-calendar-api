using Microsoft.EntityFrameworkCore;
using ZimbabweCalendar.API.Models.Data;
using ZimbabweCalendar.API.Models.Local;

namespace ZimbabweCalendar.API.Models.Repository
{
    public class HolidayRepository : IHolidayRepository
    {
        private readonly ApplicationDbContext _context;

        public HolidayRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result> AddHolidayAsync(PublicHoliday publicHoliday)
        {
            try
            {
                await _context.PublicHolidays.AddAsync(publicHoliday);
                await _context.SaveChangesAsync();
                return new Result(publicHoliday);
            }
            catch (Exception ex)
            {
                return new Result(false, 
                    new List<string>() { ex.ToString() });
            }
        }

        public async Task<Result> GetAllAsync()
        {
                var holidays = await _context.PublicHolidays.ToListAsync();
                return new Result(holidays);
        }

        public Task<Result> GetByMonthAsync(int monthId)
        {
            throw new NotImplementedException();
        }
    }
}
