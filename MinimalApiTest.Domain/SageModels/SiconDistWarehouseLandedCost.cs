using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistWarehouseLandedCost
    {
        public long SiconDistWarehouseLandedCostId { get; set; }
        public long WarehouseId { get; set; }
        public bool? Active { get; set; }
        public string? LandedCost { get; set; }
        public bool? LandedCostActive { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
