using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistLostReason
    {
        public long SiconDistLostReasonId { get; set; }
        public string? Reason { get; set; }
        public bool IncludeInMinStock { get; set; }
    }
}
