using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmbudgetVatdueByMonthView
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int YearRelativeToCurrentYear { get; set; }
        public short PeriodNumber { get; set; }
        public long NlnominalAccountId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public long ForecastDateForeignId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long SiconCfmforecastDateId { get; set; }
        public int? HasMemos { get; set; }
    }
}
