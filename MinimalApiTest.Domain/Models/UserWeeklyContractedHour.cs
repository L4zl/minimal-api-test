namespace MinimalApiTest.Domain.Models
{
    public partial class UserWeeklyContractedHour
    {
        public long UserWeeklyContractedHoursId { get; set; }
        public long? UserId { get; set; }
        public long? Year { get; set; }
        public long? Week { get; set; }
        public decimal? WeeklyContractedHours { get; set; }
        public decimal OvertimeHoursStartsAt { get; set; }
        public decimal OvertimeHours2StartsAt { get; set; }
        public decimal OvertimeHours3StartsAt { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
