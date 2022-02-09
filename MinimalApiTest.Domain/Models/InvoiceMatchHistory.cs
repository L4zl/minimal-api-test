namespace MinimalApiTest.Domain.Models
{
    public partial class InvoiceMatchHistory
    {
        public long InvoiceMatchHistoryId { get; set; }
        public long? OrderLineId { get; set; }
        public long? InvoiceLineId { get; set; }
        public long? ReceiptLineId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
