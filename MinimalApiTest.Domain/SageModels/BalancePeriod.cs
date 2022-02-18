using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BalancePeriod
    {
        public BalancePeriod()
        {
            StockItemPeriodBalances = new HashSet<StockItemPeriodBalance>();
        }

        public long BalancePeriodId { get; set; }
        public string BalancePeriodName { get; set; } = null!;
        public DateTime? PeriodOpeningDate { get; set; }
        public DateTime? PeriodClosingDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<StockItemPeriodBalance> StockItemPeriodBalances { get; set; }
    }
}
