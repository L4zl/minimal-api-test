using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLeavingReason
    {
        public long SiconTimesheetLeavingReasonId { get; set; }
        public string ReasonName { get; set; } = null!;
        public string ReasonFriendlyName { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
