namespace MinimalApiTest.Domain.Models
{
    public partial class HrupdateLink
    {
        public long HrupdateLinkId { get; set; }
        public string? Type { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ForeignId { get; set; }
        public long? HrrecordId { get; set; }
        public string? UpdateStatus { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
