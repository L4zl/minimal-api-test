using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmsectionHierarchy
    {
        public long SiconCfmsectionHierarchyId { get; set; }
        public long? SiconCfmsectionId { get; set; }
        public long? ImmedateParentSectionId { get; set; }
        public long? TopLevelSectionId { get; set; }
        public int Sequence { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
        public bool AllowMove { get; set; }
        public bool AllowChildren { get; set; }
        public bool AllowDelete { get; set; }
        public long SiconCfmsectionHeaderId { get; set; }
    }
}
