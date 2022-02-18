using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJctranRunningTotalByWeekView
    {
        public long? SiJcJobId { get; set; }
        public long? Sijcchdid { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
        public int? Weeknumber { get; set; }
        public DateTime? WeekStartDate { get; set; }
    }
}
