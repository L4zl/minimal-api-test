using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconQuestionAnswerDefinition
    {
        public long SiQuestionAnswerDefinitionId { get; set; }
        public long SiconQuestionDefinition { get; set; }
        public string AnswerText { get; set; } = null!;
        public string ReportReplacement { get; set; } = null!;
        public bool? Deleted { get; set; }
    }
}
