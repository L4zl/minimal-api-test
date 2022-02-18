using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconValuationAllocation
    {
        public long SiconValuationAllocationId { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiconConstructionAppLineId { get; set; }
        public decimal AllocatedAmount { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
