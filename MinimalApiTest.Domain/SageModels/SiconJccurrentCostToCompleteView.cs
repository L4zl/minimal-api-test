using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJccurrentCostToCompleteView
    {
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SijcPhaseId { get; set; }
        public long? SijcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public decimal? TotalToComplete { get; set; }
        public int? Period { get; set; }
        public int? PeriodYear { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public int? Week { get; set; }
        public int? Year { get; set; }
        public DateTime? PeriodEndDate { get; set; }
    }
}
