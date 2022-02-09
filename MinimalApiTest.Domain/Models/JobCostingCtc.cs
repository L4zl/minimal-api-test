namespace MinimalApiTest.Domain.Models
{
    public partial class JobCostingCtc
    {
        public long JobCostingCtcid { get; set; }
        public long? SiJccostToCompleteId { get; set; }
        public decimal? CostToComplete { get; set; }
        public decimal? HoursToComplete { get; set; }
        public string? ReasonForChange { get; set; }
        public string? CostCode { get; set; }
        public bool? SentToSage { get; set; }
        public string? UpdateStatus { get; set; }
        public string? ErrorMessage { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? Year { get; set; }
        public long? Period { get; set; }
        public long? SijcjobId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? PhaseId { get; set; }
        public long? StageId { get; set; }
        public long? SubStageId { get; set; }
        public long? ProjectVariationId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
