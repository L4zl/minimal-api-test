using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockItemLandedCost
    {
        public long SiconDistStockItemLandedCostId { get; set; }
        public long? StockItemId { get; set; }
        public decimal? LandedCost1 { get; set; }
        public decimal? LandedCost2 { get; set; }
        public decimal? LandedCost3 { get; set; }
        public decimal? LandedCost4 { get; set; }
        public decimal? LandedCost5 { get; set; }
        public decimal? LandedCost6 { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
