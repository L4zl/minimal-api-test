namespace MinimalApiTest.Domain.Models
{
    public partial class DespatchLine
    {
        public long DespatchLineId { get; set; }
        public long? DespatchId { get; set; }
        public long? SalesOrderLineId { get; set; }
        public long? SalesOrderId { get; set; }
        public long? UserId { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public DateTime? DespatchDate { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public long? SopdespatchReceiptLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public bool? SentToSage { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
