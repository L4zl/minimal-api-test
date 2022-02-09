namespace MinimalApiTest.Domain.Models
{
    public partial class Delegate
    {
        public long DelegateId { get; set; }
        public long? UserId { get; set; }
        public long? DelegateUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
