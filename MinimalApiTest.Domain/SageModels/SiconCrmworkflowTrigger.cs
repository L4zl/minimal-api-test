using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmworkflowTrigger
    {
        public long SiconCrmworkflowTriggerId { get; set; }
        public long SiconCrmworkflowId { get; set; }
        public short Sequence { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
