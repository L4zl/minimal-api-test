namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPatternPayRate
    {
        public long WorkPatternPayRateId { get; set; }
        public string? PayRateName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Standard { get; set; }
        public bool? Holiday { get; set; }
        public bool? Absence { get; set; }
        public bool UnpaidHoliday { get; set; }
    }
}
