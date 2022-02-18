using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmworkflowField
    {
        public long SiconCrmworkflowFieldId { get; set; }
        public short WorkflowType { get; set; }
        public string FieldName { get; set; } = null!;
        public string FieldFriendlyName { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
