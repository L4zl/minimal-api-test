using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipQuestionAnswer
    {
        public long SiconEquipQuestionAnswerId { get; set; }
        public long SiconEquipQuestionId { get; set; }
        public string? AnswerText { get; set; }
        public string? ReportReplacement { get; set; }
    }
}
