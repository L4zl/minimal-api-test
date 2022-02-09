namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPatternShift
    {
        public long WorkPatternShiftId { get; set; }
        public long? WorkPatternId { get; set; }
        public long? ShiftNumber { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
