using Microsoft.EntityFrameworkCore;

namespace ZimbabweCalendar.API.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PublicHoliday> PublicHolidays { get; set; }    
    }
}
