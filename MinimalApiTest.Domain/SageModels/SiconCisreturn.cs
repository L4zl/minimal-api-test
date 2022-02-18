using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCisreturn
    {
        public long SiconCisreturnId { get; set; }
        public DateTime SiconCisreturnPeriodEnd { get; set; }
        public long SiconCissupplierId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierAccountName { get; set; }
        public string? Utr { get; set; }
        public string? VerificationNo { get; set; }
        public string? Nino { get; set; }
        public decimal? SupplierTotalPayments { get; set; }
        public decimal? SupplierCostOfMaterials { get; set; }
        public decimal? SupplierOtherCost { get; set; }
        public decimal? SupplierTotalDeducted { get; set; }
        public int? SupplierTotalPaymentsInt { get; set; }
        public int? SupplierCostOfMaterialsInt { get; set; }
        public int? SupplierTotalDeductedInt { get; set; }
        public decimal? AccumulatedMaterialsRetention { get; set; }
        public decimal? AccumulatedTotalRetention { get; set; }
        public decimal? AccumulatedTotalCitb { get; set; }
        public decimal? AccumulatedMaterialsCitb { get; set; }
        public decimal? AccumulatedTotalCis { get; set; }
        public string? ExcludedFromCisreturnReason { get; set; }
        public bool? CisinactivityIndicator { get; set; }
        public bool? CisemploymentStatus { get; set; }
        public bool? CissubcontractorVerification { get; set; }
        public bool? SpareBit { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? RatePercentage { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public string? CisuploadedReturnFileName { get; set; }
        public string? CisuploadedResponseFileName { get; set; }
        public string? CishmrcresponseText { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedByDateTime { get; set; }
        public decimal AdjustmentValue { get; set; }
        public decimal TotalValue { get; set; }
        public string ChangedReason { get; set; } = null!;
        public string ChangedByUserId { get; set; } = null!;
        public DateTime? ChangedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string? DeletedBy { get; set; }
    }
}
