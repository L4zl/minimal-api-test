using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseTrackingStatus
    {
        public long SiSmcaseTrackingStatusId { get; set; }
        public string? Name { get; set; }
        public bool? AvailableToEngineers { get; set; }
    }
}
