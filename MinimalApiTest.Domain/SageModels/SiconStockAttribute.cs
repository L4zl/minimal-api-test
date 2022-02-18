using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockAttribute
    {
        public long SiconStockAttributeId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string? Colour { get; set; }
        public string? Finish { get; set; }
        public string? Gloss { get; set; }
        public decimal? SurfaceArea { get; set; }
        public decimal? Weight { get; set; }
    }
}
