using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysexchangeRateHistory
    {
        public long SysexchangeRateHistoryId { get; set; }
        public long SyscurrencyId { get; set; }
        public long SysexchangeRateActionId { get; set; }
        public string PreviousValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public DateTime DateAndTimeActionPerformed { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency Syscurrency { get; set; } = null!;
        public virtual SysexchangeRateAction SysexchangeRateAction { get; set; } = null!;
    }
}
