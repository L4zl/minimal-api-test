namespace MinimalApiTest.Domain.Models
{
    public partial class InvoiceLine
    {
        public long InvoiceLineId { get; set; }
        public long? InvoiceId { get; set; }
        public long? WaitingForId { get; set; }
        public string? WaitingForApprovalType { get; set; }
        public string? LineStatusId { get; set; }
        public long? ProjectCodeId { get; set; }
        public long? ProjectItemId { get; set; }
        public long ProjectPhaseId { get; set; }
        public long ProjectStageId { get; set; }
        public long ProjectSubStageId { get; set; }
        public long ProjectVariationId { get; set; }
        public long? SageDatabaseId { get; set; }
        public int? CurrentStep { get; set; }
        public long? NlpostedNominalTranId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Reference { get; set; }
        public string? Narrative { get; set; }
        public long? Urn { get; set; }
        public long? NlnominalAccountId { get; set; }
        public decimal? GoodsValue { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? Description { get; set; }
        public long? SystaxRateId { get; set; }
        public string? InvoiceLineType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public decimal? TaxValue { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public bool? Submitted { get; set; }
        public long? ConstructVariationId { get; set; }
        public long? ConstructLineTypeId { get; set; }
        public string? InvoiceCredit { get; set; }
        public string? TransactionAnalysisCode { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? HasAttachments { get; set; }
        public bool ResetRoute { get; set; }
        public bool IsImported { get; set; }
        public long? CreditCardId { get; set; }
        public long? CreditCardStatementLineId { get; set; }
        public long? CreditCardStatementId { get; set; }
        public long? JobRoleId { get; set; }
        public bool DuplicateMatchConfirmed { get; set; }
        public string? DuplicateMatchReason { get; set; }
        public bool VarianceLine { get; set; }
        public long? AllocatedStatus { get; set; }
        public long? ParentPlpostedSupplierTranId { get; set; }
        public bool OverBudget { get; set; }
        public bool DisableSagePosting { get; set; }
        public string? PayrollProcessReference { get; set; }
        public long? LineNumber { get; set; }
        public string? MobileGuid { get; set; }
        public long? SplitOriginatorId { get; set; }
        public string? JobManager { get; set; }
    }
}
