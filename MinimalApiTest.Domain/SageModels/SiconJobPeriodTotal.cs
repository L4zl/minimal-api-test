using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobPeriodTotal
    {
        public long SiconJobPeriodTotalId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? CostCommittedTotal { get; set; }
        public decimal? RevenueCommittedTotal { get; set; }
        public decimal? CostActualTotal { get; set; }
        public decimal? RevenueActualTotal { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
    }
}
