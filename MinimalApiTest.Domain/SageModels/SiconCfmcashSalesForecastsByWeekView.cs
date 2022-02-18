using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcashSalesForecastsByWeekView
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long SiconCfmcashSalesForecastId { get; set; }
        public long SiconCfmsectionId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long ForecastDateForeignId { get; set; }
        public int? HasMemos { get; set; }
    }
}
