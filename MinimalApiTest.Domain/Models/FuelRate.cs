namespace MinimalApiTest.Domain.Models
{
    public partial class FuelRate
    {
        public long FuelRateId { get; set; }
        public string? Name { get; set; }
        public string? CompanyPrivate { get; set; }
        public decimal? LowerRate { get; set; }
        public decimal? UpperRate { get; set; }
        public decimal? FuelComponentRate { get; set; }
        public decimal? PerPassenger { get; set; }
        public string? EngineSize { get; set; }
        public string? FuelType { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? SystemRate { get; set; }
        public long? CountryId { get; set; }
    }
}
