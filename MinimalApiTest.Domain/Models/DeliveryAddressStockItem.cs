namespace MinimalApiTest.Domain.Models
{
    public partial class DeliveryAddressStockItem
    {
        public long DeliveryAddressStockItemId { get; set; }
        public long? DeliveryAddressId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? StockItemId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
