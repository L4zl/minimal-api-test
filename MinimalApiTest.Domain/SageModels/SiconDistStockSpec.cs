using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockSpec
    {
        public long? SiconDistStockSpecId { get; set; }
        public long? ItemId { get; set; }
        public long? SiconDistStockItemLevelId { get; set; }
        public string? Name { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight { get; set; }
        public string? Barcode { get; set; }
        public decimal? QtyPerOrderItem { get; set; }
        public long? WeightTypeId { get; set; }
        public long? MeasureTypeId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
