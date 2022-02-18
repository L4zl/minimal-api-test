using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmactualVatdueByMonthView
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public long SystaxPeriodId { get; set; }
        public long SiconCfmtaxPeriodId { get; set; }
    }
}
