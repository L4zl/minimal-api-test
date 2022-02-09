namespace MinimalApiTest.Domain.Models
{
    public partial class JobCostingJob
    {
        public long JobCostingJobId { get; set; }
        public long? Sijcjobid { get; set; }
        public string? JobNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? UpdateStatus { get; set; }
        public string? ErrorMessage { get; set; }
        public string? JobManager { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Analysis1 { get; set; }
        public string? Analysis2 { get; set; }
        public string? Analysis3 { get; set; }
        public string? Analysis4 { get; set; }
        public string? Analysis5 { get; set; }
        public string? Analysis6 { get; set; }
        public string? Analysis7 { get; set; }
        public DateTime? ActualCompDate { get; set; }
        public decimal? PercentageComplete { get; set; }
        public bool? SentToSage { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? JobNotes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? PlanCompDate { get; set; }
        public string? CustomerRefCode { get; set; }
        public decimal? MarkupPercentage { get; set; }
        public decimal? StockCoverPercent { get; set; }
    }
}
