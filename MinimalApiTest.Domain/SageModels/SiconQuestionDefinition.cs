using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconQuestionDefinition
    {
        public long SiconQuestionDefinitionId { get; set; }
        public long? TemplateId { get; set; }
        public string QuestionText { get; set; } = null!;
        public bool Mandatory { get; set; }
        public int AnswerType { get; set; }
        public string? Unit { get; set; }
        public decimal? UpperLimit { get; set; }
        public bool UseLimits { get; set; }
        public decimal? LowerLimit { get; set; }
        public bool UseWarnings { get; set; }
        public decimal? UpperWarning { get; set; }
        public string UpperWarningText { get; set; } = null!;
        public decimal? LowerWarning { get; set; }
        public string LowerWarningText { get; set; } = null!;
        public bool HideFromCustomer { get; set; }
        public bool UseReportReplacementText { get; set; }
        public string DefaultAnswer { get; set; } = null!;
        public bool SelectMany { get; set; }
        public bool AllowReportAnswerReplacement { get; set; }
        public bool? Deleted { get; set; }
        public int? QuestionOrder { get; set; }
    }
}
