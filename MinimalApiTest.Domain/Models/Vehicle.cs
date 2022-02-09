namespace MinimalApiTest.Domain.Models
{
    public partial class Vehicle
    {
        public long VehicleId { get; set; }
        public string? Description { get; set; }
        public string Registration { get; set; } = null!;
        public string EngineCapacity { get; set; } = null!;
        public string? FuelType { get; set; }
        public long FuelRateId { get; set; }
        public decimal? DeliveryMileage { get; set; }
        public decimal? BusinessMileage { get; set; }
        public decimal? PersonalMileage { get; set; }
        public string? CompanyPrivate { get; set; }
        public bool? InService { get; set; }
        public string AssetNumberReference { get; set; } = null!;
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
