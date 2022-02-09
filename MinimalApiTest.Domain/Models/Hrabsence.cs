namespace MinimalApiTest.Domain.Models
{
    public partial class Hrabsence
    {
        public long HrabsenceId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? Deleted { get; set; }
        public long? RequestedById { get; set; }
        public string? RequestedByName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? LineStatus { get; set; }
        public decimal? Days { get; set; }
        public decimal? Hours { get; set; }
        public string? Description { get; set; }
        public decimal? LastPostedDays { get; set; }
        public decimal? LastPostedHours { get; set; }
        public string? ErrorMessage { get; set; }
        public string? AbsenceType { get; set; }
        public string? LineType { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public bool? Submitted { get; set; }
        public bool? ResetRoute { get; set; }
        public DateTime? SubmittedDate { get; set; }
    }
}
