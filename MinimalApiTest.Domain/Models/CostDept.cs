namespace MinimalApiTest.Domain.Models
{
    public partial class CostDept
    {
        public long CostDeptId { get; set; }
        public long? UserId { get; set; }
        public int? Step { get; set; }
        public long? AccountNumberId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? ApprovalRouteType { get; set; }
        public bool? Mandatory { get; set; }
        public long? RequestingUserId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public string? DocumentType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? OverBudget { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
    }
}
