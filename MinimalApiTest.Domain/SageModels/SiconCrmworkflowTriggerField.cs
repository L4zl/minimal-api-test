using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmworkflowTriggerField
    {
        public long SiconCrmworkflowTriggerFieldId { get; set; }
        public long SiconCrmworkflowTriggerId { get; set; }
        public string SiconCrmworkflowFieldId { get; set; } = null!;
        public short Sequence { get; set; }
        public string? Value { get; set; }
        public short ValueAction { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
