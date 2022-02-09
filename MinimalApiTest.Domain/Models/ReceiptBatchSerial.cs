namespace MinimalApiTest.Domain.Models
{
    public partial class ReceiptBatchSerial
    {
        public long ReceiptBatchSerialId { get; set; }
        public long? ReceiptLineId { get; set; }
        public long? OrderLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? PopreceiptReturnLineId { get; set; }
        public long? StockItemId { get; set; }
        public string? BatchSerialNo { get; set; }
        public string? AlternativeRef { get; set; }
        public DateTime? UseBy { get; set; }
        public DateTime? SellBy { get; set; }
        public decimal? QuantityDelivered { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Deleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? TraceableItemId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Grnnumber { get; set; }
    }
}
