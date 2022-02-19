using System.ComponentModel.DataAnnotations;

namespace ZimbabweCalendar.API.Models
{
    public class PublicHoliday
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
    }
}