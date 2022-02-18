using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetForecast
    {
        public long SiconFixedAssetForecastId { get; set; }
        public long? FixedAssetId { get; set; }
        public decimal ForecastPeriod { get; set; }
        public int ForecastYear { get; set; }
        public decimal ForecastAmount { get; set; }
        public decimal ForecastRate { get; set; }
        public decimal ForecastNetBookValue { get; set; }
        public decimal ForecastCostPrice { get; set; }
        public long? ActualTransactionId { get; set; }
        public decimal ActualPostedAmount { get; set; }
        public DateTime? ActualPostedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SysaccountingPeriodId { get; set; }
    }
}
