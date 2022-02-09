namespace MinimalApiTest.Domain.Models
{
    public partial class City
    {
        public long CityId { get; set; }
        public long? CountryId { get; set; }
        public string? Name { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
