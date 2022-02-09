namespace MinimalApiTest.Domain.Models
{
    public partial class UserTimesheetSubmission
    {
        public long UserTimesheetSubmissionId { get; set; }
        public long? UserId { get; set; }
        public long? TimesheetId { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public int? WeekNumber { get; set; }
        public int? MonthNumber { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public int? Year { get; set; }
        public bool? Deleted { get; set; }
        public long? SageDatabaseId { get; set; }
    }
}
