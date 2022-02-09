namespace MinimalApiTest.Domain.Models
{
    public partial class ReceiptBatchSerialAttribute
    {
        public long ReceiptBatchSerialAttributeId { get; set; }
        public long? ReceiptBatchSerialId { get; set; }
        public long? ProductGroupBatchAttributeId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? Title { get; set; }
        public string? ValueText { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
