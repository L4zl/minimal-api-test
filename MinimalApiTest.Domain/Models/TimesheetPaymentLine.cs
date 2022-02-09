namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetPaymentLine
    {
        public long TimesheetPaymentLineId { get; set; }
        public long? TimesheetId { get; set; }
        public long? LoginRecordLineId { get; set; }
        public long? TimesheetLineId { get; set; }
        public long? WorkPatternPayRateId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
