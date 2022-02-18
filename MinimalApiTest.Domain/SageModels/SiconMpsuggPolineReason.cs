using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpsuggPolineReason
    {
        public long SiconMpsuggPolineReasonId { get; set; }
        public long? SiWorksOrderSuggestedPolineId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public string? Reason { get; set; }
        public long? SoporderReturnLineId { get; set; }
    }
}
