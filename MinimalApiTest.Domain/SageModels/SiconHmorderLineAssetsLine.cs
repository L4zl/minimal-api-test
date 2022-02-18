using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineAssetsLine
    {
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public int? ItemSequenceNo { get; set; }
        public long CategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? QuantityInvoicedOneTime { get; set; }
        public decimal? EstimateDuration { get; set; }
        public decimal? HireUnitPrice { get; set; }
        public long? SellingTimeUnitId { get; set; }
        public bool? ExcludeWeekends { get; set; }
        public long? TaxCodeId { get; set; }
        public decimal? MinCharge { get; set; }
        public decimal? InsurancePercent { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? LineTotalChargeValue { get; set; }
        public bool? IsDurationOverridden { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public decimal? QuantityOffHire { get; set; }
        public long? ParentAssetLineId { get; set; }
    }
}
