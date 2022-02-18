using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcplannedPurchasesOutstandingView
    {
        public long SiJcJobid { get; set; }
        public long SiJcChdId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public decimal? Outstanding { get; set; }
    }
}
