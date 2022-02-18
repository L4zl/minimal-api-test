using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcstockBatchLine
    {
        public long SiconIcstockBatchLineId { get; set; }
        public long SiconIcstockBatchHeaderId { get; set; }
        public string FromStockItem { get; set; } = null!;
        public string FromWarehouse { get; set; } = null!;
        public string FromBin { get; set; } = null!;
        public string ToStockItem { get; set; } = null!;
        public string ToWarehouse { get; set; } = null!;
        public string ToBin { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal TotalValue { get; set; }
        public long AllocationLineId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
