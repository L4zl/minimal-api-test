using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcQuoteJobValue
    {
        public long SiJcQuoteJobValuesId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? JobManager { get; set; }
        public string? AnalysisType1 { get; set; }
        public string? AnalysisType2 { get; set; }
        public string? AnalysisType3 { get; set; }
        public string? AnalysisType4 { get; set; }
        public string? AnalysisType5 { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
