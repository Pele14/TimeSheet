namespace Timesheet.Api.source.Entities
{
    public class Client
    {
        public Guid Id{ get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }

        public required string Zip{ get; set;    }

        public Guid CountryId { get; set; }

        public Country Country { get; set; }=null!;

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}