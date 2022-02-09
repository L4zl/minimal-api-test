namespace MinimalApiTest.Domain.Models
{
    public partial class UserHolidayRule
    {
        public long UserHolidayRuleId { get; set; }
        public long? AlreadyBookedUserId { get; set; }
        public long? DenyUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
