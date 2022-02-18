using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcontractsDetailByMonthView
    {
        public string? Title { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? DueDate { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SiconContractId { get; set; }
        public decimal? Value { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long ForecastDateForeignId { get; set; }
        public int? HasMemos { get; set; }
    }
}
