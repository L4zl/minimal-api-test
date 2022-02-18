using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCisaudit
    {
        public long SiconCisauditId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? InvUrn { get; set; }
        public string? InvTransactionReference { get; set; }
        public DateTime? InvTransactionDate { get; set; }
        public string? InvSecondReference { get; set; }
        public decimal? InvNetValue { get; set; }
        public decimal? InvTaxValue { get; set; }
        public decimal? InvCisapplicableValue { get; set; }
        public decimal? InvLabourValue { get; set; }
        public decimal? InvMaterialsValue { get; set; }
        public decimal? InvOtherValue { get; set; }
        public decimal? InvRetentionNetValue { get; set; }
        public decimal? InvCitbnetValue { get; set; }
        public long? CrnUrn { get; set; }
        public DateTime? CrnTransactionDate { get; set; }
        public string? CrnTransactionReference { get; set; }
        public string? CrnSecondReference { get; set; }
        public decimal? CrnNetValue { get; set; }
        public decimal? CrnTaxValue { get; set; }
        public long? SiconCissupplierId { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierUtr { get; set; }
        public string? SupplierVerificationNo { get; set; }
        public string? SupplierNino { get; set; }
        public string? SupplierCrn { get; set; }
        public string? SupplierContEmpRefNo { get; set; }
        public decimal? RatePercentage { get; set; }
        public string? RateDescription { get; set; }
        public long? RateNlnominalAccountId { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public DateTime? SpareDateTime1 { get; set; }
        public DateTime? SpareDateTime2 { get; set; }
        public DateTime? SpareDateTime3 { get; set; }
        public DateTime? SpareDateTime4 { get; set; }
        public DateTime? SpareDateTime5 { get; set; }
        public string? SpareMemo1 { get; set; }
        public DateTime? PostedDate { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? CostOfMaterialsPercent { get; set; }
        public byte? IsManualDeduction { get; set; }
        public decimal? ManualRetPercent { get; set; }
        public decimal? ManualLabPercent { get; set; }
        public decimal? ManualCitbpercent { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerReference { get; set; }
    }
}
