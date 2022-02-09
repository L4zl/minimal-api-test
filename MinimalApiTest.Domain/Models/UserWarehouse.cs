namespace MinimalApiTest.Domain.Models
{
    public partial class UserWarehouse
    {
        public long UserWarehouseId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? SageDatabaseName { get; set; }
        public long? UserId { get; set; }
        public string? Username { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public bool? AvailableForRequisitionSelection { get; set; }
        public bool? AvailableForSalesOrderSelection { get; set; }
        public bool? AvailableForGoodsReceived { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? DefaultForRequisition { get; set; }
        public bool? DefaultForSalesOrder { get; set; }
        public bool? DefaultForGoodsReceived { get; set; }
    }
}
