namespace Timesheet.Api.source.Entities
{
    public class TeamMember
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public double HoursPerWeek { get; set; }

        public Role Role { get; set; }

        public MemberStatus Status { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();

        public ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
}
}