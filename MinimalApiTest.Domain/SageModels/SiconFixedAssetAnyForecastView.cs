using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetAnyForecastView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public int AnyForecasts { get; set; }
    }
}
