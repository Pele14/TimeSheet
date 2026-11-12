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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamMember>()
                .HasMany(tm => tm.Projects)
                .WithOne(p => p.TeamMember)
                .HasForeignKey(p => p.TeamMemberId);

            modelBuilder.Entity<TeamMember>()
                .HasMany(tm => tm.TimeEntries)
                .WithOne(te => te.TeamMember)
                .HasForeignKey(te => te.TeamMemberId);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.TimeEntries)
                .WithOne(te => te.Project)
                .HasForeignKey(te => te.ProjectId);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Projects)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.ClientId);

            modelBuilder.Entity<Country>()
                .HasMany(c => c.Clients)
                .WithOne(cl => cl.Country)
                .HasForeignKey(cl => cl.CountryId);
        }
    }
}