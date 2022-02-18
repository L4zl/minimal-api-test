using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesForecastExcl
    {
        public long SiconDistSalesForecastExclId { get; set; }
        public string Type { get; set; } = null!;
        public string ExcludedString { get; set; } = null!;
        public long? ExcludedId { get; set; }
    }
}
