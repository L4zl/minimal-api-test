namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPatternDay
    {
        public long WorkPatternDayId { get; set; }
        public long? WorkPatternShiftId { get; set; }
        public long? DayOfWeek { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
