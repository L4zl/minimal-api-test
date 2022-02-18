using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcbillingProfile
    {
        public long SiconJcbillingProfileId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? ItemName { get; set; }
        public decimal? FixedCost { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? ProfileStatus { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiOperationId { get; set; }
        public long? SiJcvariationId { get; set; }
    }
}
