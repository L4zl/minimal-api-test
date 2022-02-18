using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobBudgetItem
    {
        public long SiconJobBudgetItemId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public string? BudgetItemDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? BudgetAmount { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
    }
}
