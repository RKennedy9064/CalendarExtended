using CalendarExtended.Shared;
using Microsoft.EntityFrameworkCore;

namespace CalendarExtended.Server.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Calendar> Calendars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=calendar.db");
    }
}
