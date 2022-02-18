using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderForecastSoline
    {
        public long SiWorksOrderForecastSolineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SiWorksOrderForecastLineId { get; set; }
        public decimal? SolineQuantity { get; set; }
    }
}
