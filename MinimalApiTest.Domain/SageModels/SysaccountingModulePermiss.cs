using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountingModulePermiss
    {
        public long SysaccountingModulePermissId { get; set; }
        public long SysaccountingPeriodPermissId { get; set; }
        public long SysmoduleId { get; set; }
        public bool CanOpen { get; set; }
        public bool CanClose { get; set; }
        public bool CanReOpen { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysaccountingPeriodPermiss SysaccountingPeriodPermiss { get; set; } = null!;
        public virtual Sysmodule Sysmodule { get; set; } = null!;
    }
}
