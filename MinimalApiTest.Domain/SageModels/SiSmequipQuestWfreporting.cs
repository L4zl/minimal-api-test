using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmequipQuestWfreporting
    {
        public long SiconEquipQuestResponseId { get; set; }
        public long SiSmquestionWorkflowItemId { get; set; }
        public int? Ordering { get; set; }
        public int? TypeId { get; set; }
        public string? HeadingText { get; set; }
        public string? Answer { get; set; }
        public long? GridId { get; set; }
    }
}
