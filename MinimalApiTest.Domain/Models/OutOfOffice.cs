namespace MinimalApiTest.Domain.Models
{
    public partial class OutOfOffice
    {
        public long OutOfOfficeId { get; set; }
        public long? UserId { get; set; }
        public long? AlternateUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
