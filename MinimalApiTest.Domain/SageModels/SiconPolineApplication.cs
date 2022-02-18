using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPolineApplication
    {
        public long SiconPolineApplicationId { get; set; }
        public long SiconConstructionApplicationId { get; set; }
        public long SiconPurchaseOrderLineId { get; set; }
        public decimal? QuantityAppliedFor { get; set; }
    }
}
