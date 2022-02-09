namespace MinimalApiTest.Domain.Models
{
    public partial class ResetCode
    {
        public long ResetCodeId { get; set; }
        public long? UserId { get; set; }
        public string? Code { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
