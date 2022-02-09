namespace MinimalApiTest.Domain.Models;

public partial class ConstructionValuation
{
    public long ConstructionValuationId { get; set; }
    public long? SageDatabaseId { get; set; }
    public long? SageValuationId { get; set; }
    public long? ApplicationId { get; set; }
    public string? Reference { get; set; }
    public string? Reference2 { get; set; }
    public string? Note { get; set; }
    public string? Supplier { get; set; }
    public DateTime? ApplicationDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? GrossApplication { get; set; }
    public decimal? Retentions { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Invoiced { get; set; }
    public decimal? Valued { get; set; }
    public string? DefaultInvoiceNumber { get; set; }
    public decimal? DiscountPercent { get; set; }
    public decimal? RetentionPercent1 { get; set; }
    public decimal? RetentionPercent2 { get; set; }
    public decimal? RetentionPercent3 { get; set; }
    public decimal? RetentionPercent4 { get; set; }
    public decimal? RetentionValue1 { get; set; }
    public decimal? RetentionValue2 { get; set; }
    public decimal? RetentionValue3 { get; set; }
    public decimal? RetentionValue4 { get; set; }
    public decimal? Cis { get; set; }
    public decimal? MaterialValue { get; set; }
    public decimal? LabourPercent { get; set; }
    public decimal? LabourValue { get; set; }
    public decimal? OtherValue { get; set; }
    public decimal? Citbvalue { get; set; }
    public long? ProjectId { get; set; }
    public string? DocumentStatus { get; set; }
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
    public long? SupplierId { get; set; }
    public DateTime? PaymentDue { get; set; }
}

