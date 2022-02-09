namespace MinimalApiTest.Domain.Models
{
    public partial class FuelRateHistory
    {
        public long FuelRateHistoryId { get; set; }
        public long FuelRateId { get; set; }
        public DateTime? RateStartDate { get; set; }
        public decimal? LowerRate { get; set; }
        public decimal? UpperRate { get; set; }
        public decimal? FuelComponentRate { get; set; }
        public decimal? PerPassenger { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
