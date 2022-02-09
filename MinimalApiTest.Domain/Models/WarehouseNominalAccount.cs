namespace MinimalApiTest.Domain.Models
{
    public partial class WarehouseNominalAccount
    {
        public long WarehouseNominalAccountId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? WarehouseId { get; set; }
        public long? CostCentreId { get; set; }
        public long? DepartmentId { get; set; }
        public string? CostCentreCode { get; set; }
        public string? DepartmentCode { get; set; }
        public bool? OverrideCostCentre { get; set; }
        public bool? OverrideDepartment { get; set; }
        public string? WarehouseName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
