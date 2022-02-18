using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmfixedAssetSubCategory
    {
        public long SiconHmfixedAssetSubCategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public int? SuggestedDeliveryTimeDays { get; set; }
        public int? SuggestedDeliveryTimeHours { get; set; }
        public long? DefaultTaxCodeId { get; set; }
        public decimal? InsurancePercentage { get; set; }
        public int? InspectionPeriodMonths { get; set; }
        public int? InspectionPeriodDays { get; set; }
        public int? InspectionPeriodHours { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public long? DefaultBinId { get; set; }
        public bool? IsMinimumChargeSellingUnit { get; set; }
        public int? MinimumChargeMonths { get; set; }
        public int? MinimumChargeDays { get; set; }
        public int? MinimumChargeHours { get; set; }
        public long? InspectionRequired { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? CrossHirePlsupplierAccountId { get; set; }
        public long? DefaultCrossHireTaxCodeId { get; set; }
        public bool? IsScanEnterAtDespatch { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
