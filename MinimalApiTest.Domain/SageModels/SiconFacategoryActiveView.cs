using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFacategoryActiveView
    {
        public long CategoryId { get; set; }
        public string? CategoryDescription { get; set; }
        public long? BalanceSheetNominalCode { get; set; }
        public long? ProfitAndLossNominalCode { get; set; }
        public long? FixedAssetsNominal { get; set; }
        public long? BalanceSheetNominalCodeForYear { get; set; }
        public long? AdditionsNominalCodeForYear { get; set; }
        public long? SaleOfAssetNominalCode { get; set; }
        public long? WriteOffNominalCode { get; set; }
        public long? DepreciationOnDisposalsNc { get; set; }
        public long? CostDisposalNominalCode { get; set; }
        public bool? VehicleCategory { get; set; }
        public bool? PlannedPreventativeMaintenance { get; set; }
        public bool Removed { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? DefaultDepreciationTypeId { get; set; }
        public string? DefaultWhenToPostDepreciation { get; set; }
        public decimal? DefaultExpectedLife { get; set; }
        public decimal? DefaultExpectedLifeLeft { get; set; }
        public decimal? DefaultDepreciationRate { get; set; }
        public long? DefaultSiJcChdId { get; set; }
    }
}
