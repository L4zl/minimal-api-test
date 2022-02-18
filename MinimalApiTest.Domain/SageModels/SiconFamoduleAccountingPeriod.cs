using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFamoduleAccountingPeriod
    {
        public long SysmoduleAccountingPeriodId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SysmoduleId { get; set; }
        public long? SysmodulePostingStatusId { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
