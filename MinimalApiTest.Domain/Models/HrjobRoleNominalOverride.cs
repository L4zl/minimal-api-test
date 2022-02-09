namespace MinimalApiTest.Domain.Models
{
    public partial class HrjobRoleNominalOverride
    {
        public long HrjobRoleNominalOverrideId { get; set; }
        public long? HrjobRoleId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? AccountNumberId { get; set; }
        public long? CostCentreId { get; set; }
        public long? DepartmentId { get; set; }
        public string? InvoiceLineType { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
