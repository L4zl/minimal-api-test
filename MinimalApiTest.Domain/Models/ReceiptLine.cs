namespace MinimalApiTest.Domain.Models
{
    public partial class ReceiptLine
    {
        public long ReceiptLineId { get; set; }
        public long? ReceiptId { get; set; }
        public long? OrderLineId { get; set; }
        public long? OrderId { get; set; }
        public long? UserId { get; set; }
        public decimal? QuantityReceived { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public long? PopreceiptReturnLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public bool? SentToSage { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
