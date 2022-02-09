namespace MinimalApiTest.Domain.Models
{
    public partial class UserExpenseMeeting
    {
        public long UserExpenseMeetingId { get; set; }
        public long? UserId { get; set; }
        public long? ExpenseMeetingId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
