using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditLogHeader
    {
        public SysauditLogHeader()
        {
            SysauditLogDetails = new HashSet<SysauditLogDetail>();
        }

        public long SysauditLogHeaderId { get; set; }
        public long SysauditLogTypeId { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public long PrimaryId { get; set; }
        public string Reference { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long ParentPrimaryId { get; set; }
        public string ParentReference { get; set; } = null!;
        public string ParentName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SysauditLogOperationId { get; set; }

        public virtual SysauditLogOperation SysauditLogOperation { get; set; } = null!;
        public virtual SysauditLogType SysauditLogType { get; set; } = null!;
        public virtual ICollection<SysauditLogDetail> SysauditLogDetails { get; set; }
    }
}
