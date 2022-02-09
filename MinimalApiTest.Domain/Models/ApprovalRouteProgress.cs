namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalRouteProgress
    {
        public long ApprovalRouteProgressId { get; set; }
        public long? ApprovalRouteEntryId { get; set; }
        public long? ApprovalRouteEntryItemId { get; set; }
        public string? DocumentType { get; set; }
        public long? IapprovableId { get; set; }
        public long? IapprovableParentId { get; set; }
        public long? ApproverId { get; set; }
        public bool? OutOfOfficeApprover { get; set; }
        public long OutOfOfficeOriginalApproverId { get; set; }
        public long? Step { get; set; }
        public bool? Approved { get; set; }
        public bool? Rejected { get; set; }
        public bool? Mandatory { get; set; }
        public bool? MandatoryIfOverBudget { get; set; }
        public bool? AllowPreviousApprovers { get; set; }
        public long? RequiredNumberOfApprovers { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? MandatoryCustom1 { get; set; }
        public bool? MandatoryCustom2 { get; set; }
        public bool? MandatoryCustom3 { get; set; }
        public long? SageDatabaseId { get; set; }
    }
}
