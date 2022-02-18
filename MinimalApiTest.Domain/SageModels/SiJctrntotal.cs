using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJctrntotal
    {
        public long? Sijcjobid { get; set; }
        public long? Sijcchdid { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public int SiJcVariationId { get; set; }
    }
}
