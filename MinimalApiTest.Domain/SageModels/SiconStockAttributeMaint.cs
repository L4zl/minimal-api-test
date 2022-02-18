using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockAttributeMaint
    {
        public long SiconStockAttributeMaintId { get; set; }
        public long? StockItemId { get; set; }
        public long? ProductGroupId { get; set; }
        public bool? LengthEnabled { get; set; }
        public decimal? LengthDefaultValue { get; set; }
        public bool? WidthEnabled { get; set; }
        public decimal? WidthDefaultValue { get; set; }
        public bool? ColourEnabled { get; set; }
        public string? ColourDefaultValue { get; set; }
        public bool? GlossEnabled { get; set; }
        public string? GlossDefaultValue { get; set; }
        public bool? FinishEnabled { get; set; }
        public string? FinishDefaultValue { get; set; }
        public bool? SurfaceAreaEnabled { get; set; }
        public decimal? SurfaceAreaDefaultValue { get; set; }
        public bool? WeightEnabled { get; set; }
        public decimal? WeightDefaultValue { get; set; }
    }
}
