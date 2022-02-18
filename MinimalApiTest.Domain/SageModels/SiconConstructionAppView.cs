using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppView
    {
        public long SiconConstructionApplicationId { get; set; }
        public string ApplicationType { get; set; } = null!;
        public string? ApplicationReference { get; set; }
        public string? Application2ndReference { get; set; }
        public string? DefaultInvoiceNo { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerReference { get; set; }
        public decimal? ApplicationAppliedFor { get; set; }
        public decimal? ApplicationAppliedForNet { get; set; }
        public decimal? ApplicationValued { get; set; }
        public decimal? ApplicationValuedNet { get; set; }
        public decimal? ApplicationInvoiced { get; set; }
        public decimal? ApplicationInvoicedRet { get; set; }
        public decimal? ApplicationInvoicedNet { get; set; }
        public decimal? ApplicationReceived { get; set; }
        public decimal? ApplicationReceivedRet { get; set; }
        public decimal? ApplicationReceivedNet { get; set; }
        public decimal? ApplicationTax { get; set; }
        public decimal? ApplicationTaxNet { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal OpeningBalanceRet { get; set; }
        public decimal OpeningBalanceNet { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal RetentionTotal { get; set; }
        public decimal RiskValue { get; set; }
        public DateTime? ApplicationPostedDate { get; set; }
        public DateTime? ApplicationValuedDate { get; set; }
        public string? ApplicationStatus { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? ApplicationNo { get; set; }
        public decimal? AppliedForQuantity { get; set; }
        public decimal? ValuedQuantity { get; set; }
        public bool? Despatched { get; set; }
        public DateTime? ApplicationExpiryDate { get; set; }
        public DateTime? ValuationDate { get; set; }
        public DateTime? PayLessDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public string Queried { get; set; } = null!;
        public string Note { get; set; } = null!;
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedByDateTime { get; set; }
        public string JobManager { get; set; } = null!;
        public decimal? RetentionPercentage1 { get; set; }
        public decimal? RetentionPercentage2 { get; set; }
        public decimal? RetentionPercentage3 { get; set; }
        public decimal? RetentionPercentage4 { get; set; }
        public decimal? RetentionValue1 { get; set; }
        public decimal? RetentionValue2 { get; set; }
        public decimal? RetentionValue3 { get; set; }
        public decimal? RetentionValue4 { get; set; }
        public DateTime? RetentionDate1 { get; set; }
        public DateTime? RetentionDate2 { get; set; }
        public DateTime? RetentionDate3 { get; set; }
        public DateTime? RetentionDate4 { get; set; }
        public long? TaxCodeId { get; set; }
        public bool IsFinal { get; set; }
        public long? Retention1Id { get; set; }
        public long? Retention2Id { get; set; }
        public long? Retention3Id { get; set; }
        public long? Retention4Id { get; set; }
        public long SiJctrnApplicationGross { get; set; }
        public long SiJctrnDicount { get; set; }
        public bool ApplyDiscountFirst { get; set; }
        public int UpdateVersion { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public bool? IsAuthorised { get; set; }
        public bool? RequiresWapauthorisation { get; set; }
        public decimal? Cis { get; set; }
        public decimal? CislabourPc { get; set; }
        public decimal? CislabourValue { get; set; }
        public decimal? CismaterialsValue { get; set; }
        public decimal? CisotherValue { get; set; }
        public decimal? CitblabourPc { get; set; }
        public decimal? CitblabourValue { get; set; }
        public long? SiJcphaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public decimal? RetentionsReleased { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public long? SiconConstructionAppGroupId { get; set; }
        public int? CurrentStep { get; set; }
        public int? CurrentStepApprovalCount { get; set; }
        public long? CustomRouteId { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public bool? Submitted { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? RequestedById { get; set; }
        public long? QsemployeeId { get; set; }
        public decimal ActualRetentions { get; set; }
        public long? SyscurrencyId { get; set; }
        public string? Currency { get; set; }
        public double? JobExchangeRate { get; set; }
    }
}
