namespace MinimalApiTest.Domain.Models
{
    public partial class UserHoliday
    {
        public long UserHolidayId { get; set; }
        public long? UserId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public bool IsLocked { get; set; }
        public decimal? EntitlementDays { get; set; }
        public decimal? EntitlementHours { get; set; }
        public decimal? TakenDays { get; set; }
        public decimal? TakenHours { get; set; }
        public decimal? BookedDays { get; set; }
        public decimal? BookedHours { get; set; }
        public decimal? BroughtForwardDays { get; set; }
        public decimal? BroughtForwardHours { get; set; }
        public decimal? SubmittedDays { get; set; }
        public decimal? SubmittedHours { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Notes { get; set; }
        public decimal PaidHours { get; set; }
        public decimal PaidDays { get; set; }
        public decimal WrittenOffHours { get; set; }
        public decimal WrittenOffDays { get; set; }
        public decimal CarriedForwardHours { get; set; }
        public decimal CarriedForwardDays { get; set; }
    }
}
