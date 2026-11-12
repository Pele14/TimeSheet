namespace Timesheet.Api.source.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}