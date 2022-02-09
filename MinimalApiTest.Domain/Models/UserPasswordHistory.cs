namespace MinimalApiTest.Domain.Models
{
    public partial class UserPasswordHistory
    {
        public long UserPasswordHistoryId { get; set; }
        public long? UserId { get; set; }
        public string? Password { get; set; }
        public string? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
