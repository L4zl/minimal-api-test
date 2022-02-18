using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmsupplierApplicationsDetailByMonthView
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? PlsupplierAccountId { get; set; }
        public long SiconConstructionApplicationId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long ForecastDateForeignId { get; set; }
        public long SiconCfmforecastDateId { get; set; }
        public int? HasMemos { get; set; }
    }
}
