namespace MinimalApiTest.Domain.Models
{
    public partial class RequestForQuote
    {
        public long RequestForQuoteId { get; set; }
        public long? PrlineId { get; set; }
        public long? OrderId { get; set; }
        public string? Notes { get; set; }
        public string? LineDescription { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? SupplierId { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierAccountName { get; set; }
        public string? SupplierContactName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Reference { get; set; }
        public DateTime? EmailDate { get; set; }
    }
}
