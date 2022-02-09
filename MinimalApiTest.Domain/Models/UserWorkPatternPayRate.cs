namespace MinimalApiTest.Domain.Models
{
    public partial class UserWorkPatternPayRate
    {
        public long UserWorkPatternPayRateId { get; set; }
        public long? WorkPatternPayRateId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ForeignPayRateId { get; set; }
        public long? ForeignChargeRateId { get; set; }
        public long? ForeignCostRateId { get; set; }
        public decimal? CostRate { get; set; }
        public decimal? ChargeRate { get; set; }
        public decimal? PayRate { get; set; }
        public string? PayElementReference { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
