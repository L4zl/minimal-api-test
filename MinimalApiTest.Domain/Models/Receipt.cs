namespace MinimalApiTest.Domain.Models
{
    public partial class Receipt
    {
        public long ReceiptId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? SupplierDocumentNo { get; set; }
        public DateTime? SupplierDocumentDate { get; set; }
        public string? Narrative { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public string? UpdateStatus { get; set; }
        public string? Grnnumber { get; set; }
        public bool? SentToSage { get; set; }
        public string? SupplierAccountNo { get; set; }
        public long? SupplierId { get; set; }
        public bool? FinalReceipt { get; set; }
        public bool? HasAttachments { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
