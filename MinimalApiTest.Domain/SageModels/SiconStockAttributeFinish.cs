using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockAttributeFinish
    {
        public long SiconStockAttributeFinishId { get; set; }
        public long? SiconStockAttributeId { get; set; }
        public bool Enabled { get; set; }
        public string? Finish { get; set; }
        public string? Notes { get; set; }
        public decimal? Days { get; set; }
    }
}
