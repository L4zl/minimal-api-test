namespace MinimalApiTest.Domain.Models
{
    public partial class Timesheet
    {
        public long TimesheetId { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public long? RequestedById { get; set; }
        public long? EnteredById { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
        public bool? ConstructRelated { get; set; }
        public long? SageTimesheetId { get; set; }
        public bool? SentToSage { get; set; }
        public long? TspersonId { get; set; }
        public string? Narrative { get; set; }
        public string? Notes { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public decimal? Toiladjustment { get; set; }
        public bool? HasAnalysisValues { get; set; }
        public bool? Urgent { get; set; }
        public string? UrgentReason { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool ClearTransactions { get; set; }
        public string? MobileGuid { get; set; }
        public long? MigratedTimesheetId { get; set; }
    }
}
