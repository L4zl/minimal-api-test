﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppLineView
    {
        public long SiconConstructionAppLineId { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
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
        public DateTime? ApplicationValuedDate { get; set; }
        public decimal? AccumulatedTotal { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedByDateTime { get; set; }
        public string? Reference { get; set; }
        public long? SiJcEmpId { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? PaymentDate { get; set; }
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
        public string? EmployeeName { get; set; }
        public long? PostedSoporderLineId { get; set; }
        public long? Retention1Id { get; set; }
        public long? Retention2Id { get; set; }
        public long? Retention3Id { get; set; }
        public long? Retention4Id { get; set; }
        public string? Narrative { get; set; }
        public string? JobDescription { get; set; }
        public bool? IsPrinted { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool ApplyDiscountFirst { get; set; }
        public string? ValuationType { get; set; }
        public bool? IsOpeningBalance { get; set; }
        public bool? IsLocked { get; set; }
        public decimal? Cis { get; set; }
        public decimal? CislabourPc { get; set; }
        public decimal? CislabourValue { get; set; }
        public decimal? CismaterialsValue { get; set; }
        public decimal? CisotherValue { get; set; }
        public decimal? CitblabourPc { get; set; }
        public decimal? CitblabourValue { get; set; }
        public decimal? RetentionReleasedValue1 { get; set; }
        public decimal? RetentionReleasedValue2 { get; set; }
        public decimal? RetentionReleasedValue3 { get; set; }
        public decimal? RetentionReleasedValue4 { get; set; }
        public bool? IsSingleValuation { get; set; }
        public string? SingleValuationType { get; set; }
        public string? TraderReference { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? Ledger { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
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
        public long? SiJcTrnId { get; set; }
        public long? SiconConstructionAppGroupId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? Qsreference { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? CurrentStep { get; set; }
        public int? CurrentStepApprovalCount { get; set; }
        public long? CustomRouteId { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public bool? Submitted { get; set; }
        public long? RequestedById { get; set; }
        public string? ApprovalStatus { get; set; }
        public long? SyscurrencyId { get; set; }
        public double? JobExchangeRate { get; set; }
        public long SopinvoiceCisrctextId { get; set; }
        public int Cistax { get; set; }
        public string? InvReverseChargeText { get; set; }
        public string? CrnreverseChargeText { get; set; }
    }
}