using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmquestionWorkflowGridItem
    {
        public long SiSmquestionWorkflowGridItemId { get; set; }
        public long SiSmquestionWorkflowId { get; set; }
        public long SiSmquestionWorkflowItemId { get; set; }
        public int TypeId { get; set; }
        public long? QuestionId { get; set; }
        public string? Label { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
    }
}
