using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditLogOperation
    {
        public SysauditLogOperation()
        {
            SysauditLogHeaders = new HashSet<SysauditLogHeader>();
        }

        public long SysauditLogOperationId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysauditLogHeader> SysauditLogHeaders { get; set; }
    }
}
