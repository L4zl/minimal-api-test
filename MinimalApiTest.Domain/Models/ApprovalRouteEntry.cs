namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalRouteEntry
    {
        public long ApprovalRouteEntryId { get; set; }
        public string? DocumentType { get; set; }
        public string? ApprovalRouteEntryType { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? NominalAccountId { get; set; }
        public long? RequestingUserId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? ValueBandId { get; set; }
        public int? Step { get; set; }
        public int? RequiredNumberOfApprovers { get; set; }
        public bool? Mandatory { get; set; }
        public bool? MandatoryIfOverBudget { get; set; }
        public bool? CustomApprovalRoute { get; set; }
        public long? CustomApprovalRouteId { get; set; }
        public bool? AllowPreviousApprovers { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? MandatoryCustom1 { get; set; }
        public bool? MandatoryCustom2 { get; set; }
        public bool? MandatoryCustom3 { get; set; }
        public long? SupplierId { get; set; }
        public string? JobManager { get; set; }
    }
}
