using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmopportunityStage
    {
        public long SiconCrmopportunityStageId { get; set; }
        public string StageName { get; set; } = null!;
        public decimal? ProbabilityPercentage { get; set; }
        public bool Closed { get; set; }
        public bool IsDefault { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
