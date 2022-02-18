using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmopportunity
    {
        public long SiconTcmopportunityId { get; set; }
        public long? SiconTcmtaskId { get; set; }
        public long? ClassificationId { get; set; }
        public long? OutcomeId { get; set; }
        public decimal RevenueValue { get; set; }
        public decimal ForecastValue { get; set; }
        public short ProbabilityPercentage { get; set; }
        public short CompletePercentage { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
