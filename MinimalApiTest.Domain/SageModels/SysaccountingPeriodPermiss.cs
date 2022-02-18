using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountingPeriodPermiss
    {
        public SysaccountingPeriodPermiss()
        {
            SysaccountingModulePermisses = new HashSet<SysaccountingModulePermiss>();
        }

        public long SysaccountingPeriodPermissId { get; set; }
        public int UserId { get; set; }
        public bool ChangePeriods { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SysaccountingModulePermiss> SysaccountingModulePermisses { get; set; }
    }
}
