using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectLevelBillingMethod
    {
        public PcprojectLevelBillingMethod()
        {
            PcprojectItems = new HashSet<PcprojectItem>();
            PcprojectLevels = new HashSet<PcprojectLevel>();
        }

        public long PcprojectLevelBillingMethodId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
        public virtual ICollection<PcprojectLevel> PcprojectLevels { get; set; }
    }
}
