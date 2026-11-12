namespace Timesheet.Api.source.Entities
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProjectStatus Status { get; set; }

        public Guid ClientId { get; set; }

        public Client Client { get; set; } = null!;

        public Guid TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; } = null!;

        public ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

    }
}