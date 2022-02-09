namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetLockedWeek
    {
        public long TimesheetLockedWeekId { get; set; }
        public int? WeekNumber { get; set; }
        public int? YearNumber { get; set; }
        public int? BusinessUnitId { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
