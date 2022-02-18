using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesForecast
    {
        public long SiconDistSalesForecastId { get; set; }
        public string ForecastName { get; set; } = null!;
        public long? ItemId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal PercentageIncrease { get; set; }
        public decimal ForecastTotal { get; set; }
        public bool MrpforecastGenerated { get; set; }
        public long? WarehouseId { get; set; }
    }
}
