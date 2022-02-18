using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPartsQuestionAnswer
    {
        public long SiconPartsQuestionAnswerId { get; set; }
        public long? SiconPartsQuestionId { get; set; }
        public string? AnswerText { get; set; }
        public string? ReportReplacement { get; set; }
    }
}
