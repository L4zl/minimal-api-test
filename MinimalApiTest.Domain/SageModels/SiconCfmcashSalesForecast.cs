using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcashSalesForecast
    {
        public long SiconCfmcashSalesForecastId { get; set; }
        public long? SiconCfmsectionId { get; set; }
        public DateTime? ForecastDate { get; set; }
        public decimal Value { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string Notes { get; set; } = null!;
    }
}
