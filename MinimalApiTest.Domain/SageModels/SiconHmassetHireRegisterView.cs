using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetHireRegisterView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? SerialNumber { get; set; }
        public string? AssetTypeName { get; set; }
        public string Status { get; set; } = null!;
        public string? CategoryDescription { get; set; }
        public string? SubCategoryDescription { get; set; }
        public string? WarehouseName { get; set; }
        public string LastHireOrderNumber { get; set; } = null!;
        public decimal? RechargeSellingPrice { get; set; }
        public decimal? LostQuantity { get; set; }
        public decimal? LostValue { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
        public decimal? NetBookValue { get; set; }
        public DateTime? LastDepreciationDate { get; set; }
        public decimal? AccumulatedDepreciation { get; set; }
        public string? Description { get; set; }
        public DateTime? HoldUntilDate { get; set; }
        public decimal? CostValue { get; set; }
        public decimal? LastDepreciationValue { get; set; }
        public string? DepreciationDescription { get; set; }
        public decimal? ResidualValue { get; set; }
        public decimal? ExpectedLife { get; set; }
        public string WhenToDepreciate { get; set; } = null!;
        public decimal? DepreciationRate { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public DateTime? CapitalisationDate { get; set; }
        public string AddressDescription { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string Disposed { get; set; } = null!;
    }
}
