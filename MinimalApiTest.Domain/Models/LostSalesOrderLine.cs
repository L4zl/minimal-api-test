namespace MinimalApiTest.Domain.Models
{
    public partial class LostSalesOrderLine
    {
        public long LostSalesOrderLineId { get; set; }
        public long? SalesOrderLineId { get; set; }
        public long? CustomerId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? Date { get; set; }
        public long? StockItemId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Reason { get; set; }
        public string? AdditionalInformation { get; set; }
        public string? ErrorMessage { get; set; }
        public bool Deleted { get; set; }
        public bool SentToSage { get; set; }
        public string? RequestingUser { get; set; }
    }
}
