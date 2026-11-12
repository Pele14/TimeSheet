namespace Timesheet.Api.source.Entities
{
    public class TeamMember
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public double hoursPerWeek { get; set; }

        public Role Role { get; set; }

        public MemberStatus Status { get; set; }

        public Icollection<Project> Projects { get; set; } = new List<Project>();

        public Icollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
}
}