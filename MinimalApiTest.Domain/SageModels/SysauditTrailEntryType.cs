using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditTrailEntryType
    {
        public SysauditTrailEntryType()
        {
            SysauditTrails = new HashSet<SysauditTrail>();
        }

        public long SysauditTrailEntryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysauditTrail> SysauditTrails { get; set; }
    }
}
