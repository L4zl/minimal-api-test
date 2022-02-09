namespace MinimalApiTest.Domain.Models
{
    public partial class StockItem
    {
        public long StockItemId { get; set; }
        public string? Code { get; set; }
        public long? SageStockItemId { get; set; }
        public string? Description { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? Name { get; set; }
        public string? ProductGroup { get; set; }
        public long? ProductGroupId { get; set; }
        public long? TaxCodeId { get; set; }
        public long? WarehouseId { get; set; }
        public string? Warehouse { get; set; }
        public string? WarehouseBin { get; set; }
        public decimal? ReorderLevel { get; set; }
        public decimal? MaxLevel { get; set; }
        public decimal? MinLevel { get; set; }
        public string? Uom { get; set; }
        public decimal? StandardCostPrice { get; set; }
        public bool? AllowSalesOrder { get; set; }
        public long? DefaultSupplierId { get; set; }
        public string? DefaultSupplierCode { get; set; }
        public string? DefaultSupplierStockCode { get; set; }
        public decimal? SupplierListPrice { get; set; }
        public decimal? SupplierMinOrderQty { get; set; }
        public decimal? SupplierUsualOrderQty { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
        public long? RequestedById { get; set; }
        public string? RequestedByName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Posted { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public bool? Urgent { get; set; }
        public string? UrgentReason { get; set; }
        public string? LineStatus { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStep { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public bool? Submitted { get; set; }
        public bool? OverBudget { get; set; }
        public bool ResetRoute { get; set; }
        public DateTime? SubmittedDate { get; set; }
    }
}
