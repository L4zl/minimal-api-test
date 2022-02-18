using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodActionLog
    {
        public long SysperiodActionLogId { get; set; }
        public short PeriodNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? OldEndDate { get; set; }
        public string ModuleName { get; set; } = null!;
        public string ModulePostingStatusName { get; set; } = null!;
        public long SysperiodActionId { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime DateAndTimeActionPerformed { get; set; }
        public decimal TradingLedgerClosingTotal { get; set; }
        public decimal NominalLedgerControlTotal { get; set; }
        public bool ClosedPeriodReOpened { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysperiodAction SysperiodAction { get; set; } = null!;
    }
}
