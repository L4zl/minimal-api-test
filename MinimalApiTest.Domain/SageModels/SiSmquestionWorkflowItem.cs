using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmquestionWorkflowItem
    {
        public long SiSmquestionWorkflowItemId { get; set; }
        public long SiSmquestionWorkflowId { get; set; }
        public long? QuestionId { get; set; }
        public int TypeId { get; set; }
        public long? ParentItemId { get; set; }
        public string GroupText { get; set; } = null!;
        public long? ConditionItemId { get; set; }
        public int? Operator { get; set; }
        public string? StaticCompareValue { get; set; }
        public int? Ordering { get; set; }
        public bool? Deleted { get; set; }
        public int? Level { get; set; }
        public bool? HideFromCustomer { get; set; }
    }
}
