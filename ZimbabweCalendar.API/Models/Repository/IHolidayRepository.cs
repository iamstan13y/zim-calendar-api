using ZimbabweCalendar.API.Models.Local;

namespace ZimbabweCalendar.API.Models.Repository
{
    public interface IHolidayRepository
    {
        Task<Result> GetByMonthAsync(int monthId);
        Task<Result> GetAllAsync();
        Task<Result> AddHolidayAsync(PublicHoliday publicHoliday);
    }
}
