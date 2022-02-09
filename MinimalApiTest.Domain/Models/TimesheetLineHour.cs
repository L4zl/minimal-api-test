namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetLineHour
    {
        public long TimesheetLineHoursId { get; set; }
        public long? TimesheetLineId { get; set; }
        public int? DayOfWeek { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Deduction { get; set; }
        public string? HoursHhmm { get; set; }
        public long? PostedTransactionId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Notes { get; set; }
        public bool HotEdit { get; set; }
        public string? MobileGuid { get; set; }
    }
}
