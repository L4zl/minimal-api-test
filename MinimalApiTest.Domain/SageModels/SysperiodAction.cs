using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodAction
    {
        public SysperiodAction()
        {
            SysperiodActionLogs = new HashSet<SysperiodActionLog>();
        }

        public long SysperiodActionId { get; set; }
        public long SysperiodActionTypeId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysperiodActionType SysperiodActionType { get; set; } = null!;
        public virtual ICollection<SysperiodActionLog> SysperiodActionLogs { get; set; }
    }
}
