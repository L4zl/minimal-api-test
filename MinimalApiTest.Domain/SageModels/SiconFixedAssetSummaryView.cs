using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetSummaryView
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
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
        public string? CategoryDescription { get; set; }
        public string? SubCategoryDescription { get; set; }
        public string? AddressDescription { get; set; }
        public string? AddressDepartment { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? PostCode { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string? AssetType { get; set; }
        public string? SerialNumber { get; set; }
        public string Disposed { get; set; } = null!;
        public string? Status { get; set; }
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
        public long? SiJcJobId { get; set; }
    }
}
