using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmpurchasesRetentionsDetailByDayView
    {
        public string? Title { get; set; }
        public string Description { get; set; } = null!;
        public long? PlsupplierAccountId { get; set; }
        public long SiconRetentionId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long ForecastDateForeignId { get; set; }
        public long SiconCfmforecastDateId { get; set; }
        public int? HasMemos { get; set; }
    }
}
