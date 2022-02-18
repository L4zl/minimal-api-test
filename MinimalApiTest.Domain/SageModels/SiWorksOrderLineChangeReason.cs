using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderLineChangeReason
    {
        public long SiWorksOrderLineChangeReasonId { get; set; }
        public string? Reason { get; set; }
        public bool? Default { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
