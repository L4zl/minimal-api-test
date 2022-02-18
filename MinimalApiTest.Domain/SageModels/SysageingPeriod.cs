using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysageingPeriod
    {
        public long SysageingPeriodId { get; set; }
        public short DaysPeriodStartsAfter { get; set; }
        public bool SalesLedgerOrPurchaseLedger { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
