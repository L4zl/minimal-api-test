using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectsSummaryBudgetView
    {
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? JobItemTypeCode { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public decimal? BudgetAmount { get; set; }
    }
}
