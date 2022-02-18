using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconInspectionAnswer
    {
        public long SiconInspectionAnswerId { get; set; }
        public long SiconInspection { get; set; }
        public long SiconQuestionDefinition { get; set; }
        public string QuestionText { get; set; } = null!;
        public string AnswerText { get; set; } = null!;
        public bool? Deleted { get; set; }
    }
}
