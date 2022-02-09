namespace MinimalApiTest.Domain.Models
{
    public partial class ProposedPaymentLine
    {
        public long ProposedPaymentLineId { get; set; }
        public long? ProposedPaymentId { get; set; }
        public long? PlproposedPaymentId { get; set; }
        public long? PlproposedPaymentPostedTranId { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public decimal? DiscountToClaimValue { get; set; }
        public decimal? ToPayValue { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public string? TransType { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Reference { get; set; }
        public decimal? Value { get; set; }
        public decimal? Vatdiscount { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? Submitted { get; set; }
        public long? ValueBandId { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public string? RejectReason { get; set; }
        public long? CustomRouteId { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CurrentStep { get; set; }
        public string? AuthoriseStatus { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? HasAttachments { get; set; }
        public bool? ResetRoute { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? LineNumber { get; set; }
        public long? InvoiceId { get; set; }
    }
}
