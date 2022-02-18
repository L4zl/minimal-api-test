using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesForecastPeriod
    {
        public long SiconDistSalesForecastPeriodId { get; set; }
        public long? SiconDistSalesForecastId { get; set; }
        public string PeriodDateString { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Forecast { get; set; }
    }
}
