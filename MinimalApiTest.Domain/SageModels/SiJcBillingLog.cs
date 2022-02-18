using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcBillingLog
    {
        public long SiJcBillingLogId { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? SysAccountingPeriodId { get; set; }
        public long? RateId { get; set; }
    }
}
