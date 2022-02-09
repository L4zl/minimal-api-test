namespace MinimalApiTest.Domain.Models
{
    public partial class OrderTemplateLine
    {
        public long OrderTemplateLineId { get; set; }
        public long? OrderTemplateId { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? Quantity { get; set; }
        public string? Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? Deleted { get; set; }
        public string? LineType { get; set; }
        public long? StockItemId { get; set; }
        public string? StockItemCode { get; set; }
        public string? SupplierPartNo { get; set; }
        public string? BuyingUnitDescription { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public long? SupplierId { get; set; }
        public long? NominalAccountId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierReference { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
