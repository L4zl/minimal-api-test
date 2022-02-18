using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppTran
    {
        public long SiconConstructionAppTranId { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiconConstructionAppLineId { get; set; }
        public string TranType { get; set; } = null!;
        public long Urn { get; set; }
        public decimal? Value { get; set; }
    }
}
