using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistLandedCostCommodity
    {
        public long SiDistLandedCostCommodityId { get; set; }
        public string CommodityCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal LandedCost1 { get; set; }
        public decimal LandedCost2 { get; set; }
        public decimal LandedCost3 { get; set; }
        public decimal LandedCost4 { get; set; }
        public decimal LandedCost5 { get; set; }
        public decimal LandedCost6 { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
