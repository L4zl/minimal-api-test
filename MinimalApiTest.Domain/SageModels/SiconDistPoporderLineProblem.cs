using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoporderLineProblem
    {
        public long SiconDistPoporderLineProblemId { get; set; }
        public string Problem { get; set; } = null!;
        public long? PoporderReturnLineId { get; set; }
        public long? SiconDistTrackingLineId { get; set; }
        public long? SiconDistPotrackingLineId { get; set; }
        public bool Resolved { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}
