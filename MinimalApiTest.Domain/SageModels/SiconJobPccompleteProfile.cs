using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobPccompleteProfile
    {
        public long SiconJobPccompleteProfileId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? PercentComplete { get; set; }
    }
}
