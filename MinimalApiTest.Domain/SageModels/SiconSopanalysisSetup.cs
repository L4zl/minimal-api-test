using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopanalysisSetup
    {
        public long SiconSopanalysisSetupId { get; set; }
        public string? AnalysisIndex { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsMandatory { get; set; }
        public string? StockAnalysisCode { get; set; }
        public string? SopanalysisCode { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
