namespace Timesheet.Api.source.Entities
{
   public class TimeEntry
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public double Time { get; set; }

        public double? Overtime { get; set; }

        public string? Description { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public Guid ProjectId { get; set; }

        public Project Project { get; set; } = null!;

        public Guid TeamMemberId { get; set; }

        public TeamMember TeamMember { get; set; } = null!;
    }
}