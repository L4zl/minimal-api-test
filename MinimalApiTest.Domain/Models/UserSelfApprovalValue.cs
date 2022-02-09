namespace MinimalApiTest.Domain.Models
{
    public partial class UserSelfApprovalValue
    {
        public long UserSelfApprovalValueId { get; set; }
        public long? UserId { get; set; }
        public string? DocumentType { get; set; }
        public decimal? ApprovalValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
