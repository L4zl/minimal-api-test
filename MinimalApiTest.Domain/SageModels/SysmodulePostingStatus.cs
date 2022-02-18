using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysmodulePostingStatus
    {
        public SysmodulePostingStatus()
        {
            SysmoduleAccountingPeriods = new HashSet<SysmoduleAccountingPeriod>();
        }

        public long SysmodulePostingStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysmoduleAccountingPeriod> SysmoduleAccountingPeriods { get; set; }
    }
}
