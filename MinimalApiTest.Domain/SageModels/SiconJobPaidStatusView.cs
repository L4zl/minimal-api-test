using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobPaidStatusView
    {
        public long SiJcJobId { get; set; }
        public string PaidStatus { get; set; } = null!;
    }
}
