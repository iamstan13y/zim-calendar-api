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

        public async Task<Result<PublicHoliday>> AddHolidayAsync(PublicHoliday publicHoliday)
        {
            try
            {
                await _context.PublicHolidays.AddAsync(publicHoliday);
                await _context.SaveChangesAsync();
                return new Result<PublicHoliday>(publicHoliday);
            }
            catch (Exception ex)
            {
                return new Result<PublicHoliday>(false, 
                    new List<string>() { ex.ToString() });
            }
        }

        public Task<Result<IEnumerable<PublicHoliday>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<PublicHoliday>>> GetByMonthAsync(int monthId)
        {
            throw new NotImplementedException();
        }
    }
}
