using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysuserPermission
    {
        public long SysuserPermissionId { get; set; }
        public long SysuserId { get; set; }
        public bool AddAmendDeletetPeriods { get; set; }
        public bool OpenFuturePeriodsSales { get; set; }
        public bool OpenFuturePeriodsPurchases { get; set; }
        public bool OpenFuturePeriodsCashBook { get; set; }
        public bool OpenFuturePeriodsStock { get; set; }
        public bool OpenFuturePeriodsNladjustments { get; set; }
        public bool ClosePeriodsSales { get; set; }
        public bool ClosePeriodsPurchases { get; set; }
        public bool ClosePeriodsCashBook { get; set; }
        public bool ClosePeriodsStock { get; set; }
        public bool ClosePeriodsNominalAdjustments { get; set; }
        public bool ReOpenPeriodsSales { get; set; }
        public bool ReOpenPeriodsPurchases { get; set; }
        public bool ReOpenPeriodsCashBook { get; set; }
        public bool ReOpenPeriodsStock { get; set; }
        public bool ReOpenPeriodsNladjustments { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Sysuser Sysuser { get; set; } = null!;
    }
}
