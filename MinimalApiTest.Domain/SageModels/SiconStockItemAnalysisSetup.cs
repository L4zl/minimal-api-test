using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockItemAnalysisSetup
    {
        public long SiconStockItemAnalysisSetupId { get; set; }
        public string? AnalysisIndex { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsMandatory { get; set; }
        public string? AnalysisType { get; set; }
        public string? AnalysisLabel { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
