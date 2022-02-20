namespace ZimbabweCalendar.API.Models.Repository
{
    public interface IHolidayRepository
    {
        Task<IEnumerable<PublicHoliday>> GetByMonthAsync(int monthId);
        Task<IEnumerable<PublicHoliday>> GetAllAsync();
        Task<PublicHoliday> AddAsync(PublicHoliday publicHoliday);
    }
}
