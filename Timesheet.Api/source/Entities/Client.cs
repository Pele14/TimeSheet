namespace Timesheet.Api.source.Entities
{
    public class Clent
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string Zip{ get; set;    }

        public Guid CountryId { get; set; }

        public Country Country { get; set; }=null!;

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}