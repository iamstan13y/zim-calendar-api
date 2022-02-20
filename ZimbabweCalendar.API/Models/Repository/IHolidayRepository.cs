using ZimbabweCalendar.API.Models.Local;

namespace ZimbabweCalendar.API.Models.Repository
{
    public interface IHolidayRepository
    {
        Task<Result<IEnumerable<PublicHoliday>>> GetByMonthAsync(int monthId);
        Task<Result<IEnumerable<PublicHoliday>>> GetAllAsync();
        Task<Result<PublicHoliday>> AddHolidayAsync(PublicHoliday publicHoliday);
    }
}
