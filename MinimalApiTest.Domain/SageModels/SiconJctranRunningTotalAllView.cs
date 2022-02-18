using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJctranRunningTotalAllView
    {
        public long? SiJcJobId { get; set; }
        public long? Sijcchdid { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
    }
}
