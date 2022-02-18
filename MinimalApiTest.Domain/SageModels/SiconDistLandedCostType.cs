using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistLandedCostType
    {
        public long SiconDistLandedCostTypeId { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }
        public long? Nominal { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
