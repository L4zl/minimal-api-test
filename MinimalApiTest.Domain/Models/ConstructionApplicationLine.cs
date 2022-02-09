﻿namespace MinimalApiTest.Domain.Models
{
    public partial class ConstructionApplicationLine
    {
        public long ConstructionApplicationLineId { get; set; }
        public long? ConstructionApplicationId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? ValuationType { get; set; }
        public decimal? ValueQuantity { get; set; }
        public decimal? ApplicationValued { get; set; }
        public decimal? ApplicationValuedNet { get; set; }
        public decimal? ApplicationValuedRet { get; set; }
        public decimal? InvoicedValue { get; set; }
        public decimal? InvoicedValueNet { get; set; }
        public decimal? ReceivedValue { get; set; }
        public decimal? RetentionTotal { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? TaxValueNet { get; set; }
        public decimal? AccumulatedTotal { get; set; }
        public DateTime? ApplicationValuedDate { get; set; }
        public string? Reference { get; set; }
        public bool? Despatched { get; set; }
        public DateTime? PaymentDate { get; set; }
        public long? Retention1Id { get; set; }
        public long? Retention2Id { get; set; }
        public long? Retention3Id { get; set; }
        public long? Retention4Id { get; set; }
        public DateTime? RetentionDate1 { get; set; }
        public DateTime? RetentionDate2 { get; set; }
        public DateTime? RetentionDate3 { get; set; }
        public DateTime? RetentionDate4 { get; set; }
        public decimal? RetentionPercentage1 { get; set; }
        public decimal? RetentionPercentage2 { get; set; }
        public decimal? RetentionPercentage3 { get; set; }
        public decimal? RetentionPercentage4 { get; set; }
        public decimal? RetentionValue1 { get; set; }
        public decimal? RetentionValue2 { get; set; }
        public decimal? RetentionValue3 { get; set; }
        public decimal? RetentionValue4 { get; set; }
        public long? TaxCodeId { get; set; }
        public string? Narrative { get; set; }
        public string? JobDescription { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? ApplyDiscountFirst { get; set; }
        public bool? IsOpeningBalance { get; set; }
        public bool? IsLocked { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
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
        public long? SageLineId { get; set; }
        public long? RequestedById { get; set; }
        public long? SiJcEmpId { get; set; }
    }
}