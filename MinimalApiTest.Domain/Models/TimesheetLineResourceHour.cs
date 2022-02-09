namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetLineResourceHour
    {
        public long TimesheetLineResourceHoursId { get; set; }
        public long? TimesheetId { get; set; }
        public long? TimesheetLineId { get; set; }
        public long? TimesheetLineHoursId { get; set; }
        public long? ResourceId { get; set; }
        public int? DayOfWeek { get; set; }
        public long? PostedTransactionId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool IsEmployee { get; set; }
    }
}
