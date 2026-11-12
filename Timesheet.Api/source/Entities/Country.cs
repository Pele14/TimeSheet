namespace Timesheet.Api.source.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public ICollection<Client> Clients { get; set; } = new List<Client>();
    }
}