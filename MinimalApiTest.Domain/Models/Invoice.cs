namespace MinimalApiTest.Domain.Models
{
    public partial class Invoice
    {
        public long InvoiceId { get; set; }
        public long? SupplierId { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierName { get; set; }
        public bool? Deleted { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? GoodsValue { get; set; }
        public decimal? TaxValue { get; set; }
        public string? Reference { get; set; }
        public string? SecondReference { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public string? RequestedByName { get; set; }
        public string? InvoiceStatus { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? SageDatabaseName { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? Urn { get; set; }
        public string? UpdateStatus { get; set; }
        public string? InvoiceExpense { get; set; }
        public long? RequestedById { get; set; }
        public long? EnteredById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? SentToSage { get; set; }
        public string? Notes { get; set; }
        public bool? HasAttachments { get; set; }
        public bool? HasAnalysisValues { get; set; }
        public bool? ConstructRelated { get; set; }
        public bool? CheckForNewDocuments { get; set; }
        public bool? OnHold { get; set; }
        public string? OnHoldReason { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public bool? Urgent { get; set; }
        public string? UrgentReason { get; set; }
        public bool? MandatoryCustom1 { get; set; }
        public bool? MandatoryCustom2 { get; set; }
        public bool? MandatoryCustom3 { get; set; }
        public bool? InvoiceRecordedFromPo { get; set; }
        public bool RequiresVarianceLine { get; set; }
        public decimal? RecordedPoreceivedGoodsValue { get; set; }
        public bool VarianceCheck { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? MobileGuid { get; set; }
        public long BusinessUnitId { get; set; }
        public long SiconDmsaiinvoiceId { get; set; }
        public decimal ConsLabourPercent { get; set; }
        public decimal ConsLabourValue { get; set; }
        public decimal ConsOtherValue { get; set; }
        public decimal ConsMaterialValue { get; set; }
        public decimal ConsRetentionWorksPracticalPercent { get; set; }
        public DateTime? ConsRetentionWorksPracticalDueDate { get; set; }
        public decimal ConsRetentionWorksDefectsPercent { get; set; }
        public DateTime? ConsRetentionWorksDefectsDueDate { get; set; }
        public decimal ConsRetentionMaterialsPracticalPercent { get; set; }
        public DateTime? ConsRetentionMaterialsPracticalDueDate { get; set; }
        public decimal ConsRetentionMaterialsDefectsPercent { get; set; }
        public DateTime? ConsRetentionMaterialsDefectsDueDate { get; set; }
        public bool? ConsIsConstructionInvoice { get; set; }
        public bool? ForReview { get; set; }
    }
}
