namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetPaymentLineHour
    {
        public long TimesheetPaymentLineHoursId { get; set; }
        public long? TimesheetPaymentLineId { get; set; }
        public int? DayOfWeek { get; set; }
        public decimal? Hours { get; set; }
        public string? HoursHhmm { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
