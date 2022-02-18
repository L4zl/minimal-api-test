using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemBudgetPdHistory
    {
        public long PcprojectItemBudgetPdHistoryId { get; set; }
        public long PcprojectItemId { get; set; }
        public long PcprojectItemBudgetHistoryId { get; set; }
        public long PcprojectItemBudgetPeriodId { get; set; }
        public decimal TotalCostQuantity { get; set; }
        public decimal TotalCostValue { get; set; }
        public decimal TotalRevenueQuantity { get; set; }
        public decimal TotalRevenueValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
        public virtual PcprojectItemBudgetHistory PcprojectItemBudgetHistory { get; set; } = null!;
        public virtual SysaccountingPeriod PcprojectItemBudgetPeriod { get; set; } = null!;
    }
}
