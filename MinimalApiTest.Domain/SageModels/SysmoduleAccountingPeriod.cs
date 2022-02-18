using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysmoduleAccountingPeriod
    {
        public long SysmoduleAccountingPeriodId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long SysmoduleId { get; set; }
        public long SysmodulePostingStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysaccountingPeriod SysaccountingPeriod { get; set; } = null!;
        public virtual Sysmodule Sysmodule { get; set; } = null!;
        public virtual SysmodulePostingStatus SysmodulePostingStatus { get; set; } = null!;
    }
}
