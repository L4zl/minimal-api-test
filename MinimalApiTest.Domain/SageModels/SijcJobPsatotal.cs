using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SijcJobPsatotal
    {
        public decimal? Cost { get; set; }
        public decimal? Revenue { get; set; }
        public long SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
    }
}
