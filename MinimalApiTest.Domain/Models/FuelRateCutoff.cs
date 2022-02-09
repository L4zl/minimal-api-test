namespace MinimalApiTest.Domain.Models
{
    public partial class FuelRateCutoff
    {
        public long FuelRateCutoffId { get; set; }
        public long FuelRateHistoryId { get; set; }
        public decimal? Cutoff { get; set; }
        public decimal? Rate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
