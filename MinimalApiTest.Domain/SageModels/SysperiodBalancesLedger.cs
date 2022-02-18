using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodBalancesLedger
    {
        public SysperiodBalancesLedger()
        {
            SysperiodBalancesAccounts = new HashSet<SysperiodBalancesAccount>();
        }

        public long SysperiodBalancesLedgerId { get; set; }
        public long SysmoduleId { get; set; }
        public string WhoRunBy { get; set; } = null!;
        public DateTime DateRun { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Sysmodule Sysmodule { get; set; } = null!;
        public virtual ICollection<SysperiodBalancesAccount> SysperiodBalancesAccounts { get; set; }
    }
}
