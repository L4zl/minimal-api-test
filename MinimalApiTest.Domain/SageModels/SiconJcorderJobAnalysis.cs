using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcorderJobAnalysis
    {
        public long SiconJcOrderJobAnalysisId { get; set; }
        public string? OrderType { get; set; }
        public long? OrderId { get; set; }
        public string? JobNumber { get; set; }
        public long? PhaseId { get; set; }
        public long? StageId { get; set; }
        public long? ActivityId { get; set; }
        public long? VariationId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiconJobAddressId { get; set; }
        public DateTime? LastUpdatedDateTimeId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
    }
}
