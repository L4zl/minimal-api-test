namespace MinimalApiTest.Domain.Models
{
    public partial class UserTimeRule
    {
        public long UserTimeRuleId { get; set; }
        public long? UserId { get; set; }
        public string? PayrollPayElementReference { get; set; }
        public string? PayrollPayElementDescription { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? Day { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StartAllowance { get; set; }
        public DateTime? LunchStartTime { get; set; }
        public DateTime? LunchEndTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? EndAllowance { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? RecordType { get; set; }
        public string? CostingModule { get; set; }
        public long? CostRateId { get; set; }
        public decimal? Hours { get; set; }
    }
}
