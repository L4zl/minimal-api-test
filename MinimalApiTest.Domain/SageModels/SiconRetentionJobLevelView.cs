using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionJobLevelView
    {
        public string? JobNumber { get; set; }
        public decimal? TotalSlnetRetentionValue { get; set; }
        public decimal? TotalPlnetRetentionValue { get; set; }
        public decimal? TotalSlcnoutstandingValueNet { get; set; }
        public decimal? TotalPlcnoutstandingValueNet { get; set; }
    }
}
