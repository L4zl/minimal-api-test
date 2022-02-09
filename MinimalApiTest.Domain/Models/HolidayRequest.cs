namespace MinimalApiTest.Domain.Models
{
    public partial class HolidayRequest
    {
        public long HolidayRequestId { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public bool? Urgent { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
        public long? RequestedById { get; set; }
        public long? EnteredById { get; set; }
        public string? RequestedByName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal? TotalHours { get; set; }
        public bool? Posted { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public string? UrgentReason { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool? Adjustment { get; set; }
        public string? DocumentType { get; set; }
    }
}
