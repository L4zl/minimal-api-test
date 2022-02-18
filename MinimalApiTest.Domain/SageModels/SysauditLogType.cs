using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditLogType
    {
        public SysauditLogType()
        {
            SysauditLogHeaders = new HashSet<SysauditLogHeader>();
        }

        public long SysauditLogTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysauditLogHeader> SysauditLogHeaders { get; set; }
    }
}
