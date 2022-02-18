using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconApplicationActualRetentionView
    {
        public long? SiconConstructionApplicationId { get; set; }
        public decimal? ActualRetentions { get; set; }
    }
}
