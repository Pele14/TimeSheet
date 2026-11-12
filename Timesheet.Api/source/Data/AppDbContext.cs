using Microsoft.EntityFrameworkCore;
using Timesheet.Api.source.Entities;

namespace Timesheet.Api.source.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}