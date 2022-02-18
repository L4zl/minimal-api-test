using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRevisedBudgetsByPeriodView
    {
        public long SiJcJobId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? TotalToComplete { get; set; }
        public string? HeaderType { get; set; }
    }
}
