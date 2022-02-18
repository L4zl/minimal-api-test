using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbillLine
    {
        public long SiconHmbillLineId { get; set; }
        public long? SiconHmorderLineAssetsLineId { get; set; }
        public long? SellingUnitId { get; set; }
        public decimal? Duration { get; set; }
        public decimal? Quantity { get; set; }
        public long SiconHmbillId { get; set; }
        public DateTime? BillCoverFromDate { get; set; }
        public DateTime? BillCoverToDate { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SiconHmorderLineChargeLineId { get; set; }
        public long? SiconHmorderLineStockLineId { get; set; }
        public long? LineTypeId { get; set; }
        public long? SiconHmorderLineCreditLineId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }
        public bool? IsLastChargeForAsset { get; set; }
        public string? WarningMessage { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public decimal? NotBilledQuantity { get; set; }
    }
}
