using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipQuestResponseAn
    {
        public long SiconEquipQuestResponseAnsId { get; set; }
        public long SiconEquipQuestResponseId { get; set; }
        public long SiconEquipQuestionId { get; set; }
        public string? AnswerText { get; set; }
        public int? Order { get; set; }
        public long? SiSmquestionWorkflowItemId { get; set; }
        public bool? Inactive { get; set; }
        public long? SiSmquestionWorkflowGridItemId { get; set; }
        public string? Username { get; set; }
    }
}
