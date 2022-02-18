using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockItem
    {
        public long? SiconDistStockItemId { get; set; }
        public long? ItemId { get; set; }
        public decimal? PalletQty { get; set; }
        public decimal? BoxQty { get; set; }
        public int? StockCoverInDays { get; set; }
        public int? ForecastRounding { get; set; }
        public bool UseContainerLoading { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool? ItemSuperseded { get; set; }
        public long? SupersededItemId { get; set; }
        public bool? DoNotIncludeInMinimumCalc { get; set; }
        public decimal? SafetyMargin { get; set; }
        public bool Discontinued { get; set; }
    }
}
