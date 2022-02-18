using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemPeriodBalance
    {
        public long StockItemPeriodBalanceId { get; set; }
        public long ItemId { get; set; }
        public long BalancePeriodId { get; set; }
        public decimal QuantitySold { get; set; }
        public decimal QuantityPurchased { get; set; }
        public decimal SalesValueSold { get; set; }
        public decimal CostValueSold { get; set; }
        public decimal ValuePurchased { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BalancePeriod BalancePeriod { get; set; } = null!;
        public virtual StockItem Item { get; set; } = null!;
    }
}
