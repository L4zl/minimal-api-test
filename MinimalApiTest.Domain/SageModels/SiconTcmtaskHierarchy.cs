using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtaskHierarchy
    {
        public long SiconTcmtaskHierarchyId { get; set; }
        public long? SiconTcmtaskId { get; set; }
        public long? ImmediateParentTaskId { get; set; }
        public long? TopLevelTaskId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
