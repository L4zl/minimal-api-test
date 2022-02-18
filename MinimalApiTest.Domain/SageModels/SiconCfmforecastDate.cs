using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmforecastDate
    {
        public long SiconCfmforecastDateId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long? ForecastDateForeignId { get; set; }
        public DateTime? ForecastDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
