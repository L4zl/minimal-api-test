using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditLogDetail
    {
        public long SysauditLogDetailId { get; set; }
        public long SysauditLogHeaderId { get; set; }
        public string FieldName { get; set; } = null!;
        public string FriendlyName { get; set; } = null!;
        public string OldValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysauditLogHeader SysauditLogHeader { get; set; } = null!;
    }
}
