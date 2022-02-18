using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContactPersonHierarchy
    {
        public long SiconContactPersonHierarchyId { get; set; }
        public long? SiconContactPersonId { get; set; }
        public long? ImmediateParentPersonId { get; set; }
        public long? TopLevelPersonId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
