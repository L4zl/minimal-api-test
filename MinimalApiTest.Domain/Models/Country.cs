namespace MinimalApiTest.Domain.Models
{
    public partial class Country
    {
        public long CountryId { get; set; }
        public string? Name { get; set; }
        public string? Alpha2 { get; set; }
        public string? Alpha3 { get; set; }
        public string? Flag { get; set; }
        public bool? Selectable { get; set; }
        public bool? DefaultCountry { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? MileageUnit { get; set; }
        public DateTime? MileageYearChange { get; set; }
    }
}
