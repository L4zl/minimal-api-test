using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSfdcstopReason
    {
        public long SiconSfdcstopReasonId { get; set; }
        public string ReasonName { get; set; } = null!;
        public string ReasonFriendlyName { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
