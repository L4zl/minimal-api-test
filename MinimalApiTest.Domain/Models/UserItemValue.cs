namespace MinimalApiTest.Domain.Models
{
    public partial class UserItemValue
    {
        public long UserItemValueId { get; set; }
        public long? UserId { get; set; }
        public string? DocumentType { get; set; }
        public string? UserItemValueType { get; set; }
        public decimal? ApprovalValue { get; set; }
        public decimal? RequestValue { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ValueTypeForeignId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
