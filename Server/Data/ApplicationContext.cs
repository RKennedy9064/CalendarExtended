using CalendarExtended.Shared;
using Microsoft.EntityFrameworkCore;

namespace CalendarExtended.Server.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CalendarEvent> CalendarEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=calendar.db");
    }
}
