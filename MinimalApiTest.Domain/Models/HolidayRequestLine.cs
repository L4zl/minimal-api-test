namespace MinimalApiTest.Domain.Models
{
    public partial class HolidayRequestLine
    {
        public long HolidayRequestLineId { get; set; }
        public long? HolidayRequestId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? Deleted { get; set; }
        public long? RequestedById { get; set; }
        public string? RequestedByName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? LineStatus { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStep { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public decimal? Days { get; set; }
        public decimal? Hours { get; set; }
        public string? Description { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public bool? Conflicts { get; set; }
        public bool? Submitted { get; set; }
        public bool? OverBudget { get; set; }
        public decimal? LastPostedDays { get; set; }
        public decimal? LastPostedHours { get; set; }
        public long? UserHolidayId { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? Unpaid { get; set; }
        public bool? Toil { get; set; }
        public bool? Cancelled { get; set; }
        public bool ResetRoute { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? LineType { get; set; }
        public long? ForeignId { get; set; }
        public bool? Remove { get; set; }
        public bool? Adjustment { get; set; }
        public long? AlternativeUserId { get; set; }
        public long? LineNumber { get; set; }
        public string? MobileGuid { get; set; }
        public long? LeaveTypeId { get; set; }
        public string? DocumentType { get; set; }
        public bool? HideDescription { get; set; }
        public long? ToilbankPeriodId { get; set; }
        public long? ToilbankMonth { get; set; }
        public decimal? BreakAmount { get; set; }
    }
}
