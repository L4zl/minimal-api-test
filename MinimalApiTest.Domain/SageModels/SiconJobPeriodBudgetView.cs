using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobPeriodBudgetView
    {
        public long SiconJobPeriodBudgetId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? Budget { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public decimal? BudgetTotal { get; set; }
    }
}
