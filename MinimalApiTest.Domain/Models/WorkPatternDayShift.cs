namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPatternDayShift
    {
        public long WorkPatternDayShiftId { get; set; }
        public long? WorkPatternDayId { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Duration { get; set; }
        public long? WorkPatternPayRateId { get; set; }
        public string? DayShiftType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? NonWorking { get; set; }
        public long? Priority { get; set; }
    }
}
