using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcontractLinesDetailByMonthView
    {
        public DateTime? DueDate { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Value { get; set; }
        public long SiconContractId { get; set; }
        public long SiconContractLineId { get; set; }
        public long ForecastDateForeignId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public int? HasMemos { get; set; }
    }
}
