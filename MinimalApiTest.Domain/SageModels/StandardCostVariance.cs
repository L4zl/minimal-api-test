using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StandardCostVariance
    {
        public long StandardCostVarianceId { get; set; }
        public long StockItemId { get; set; }
        public string CostCentre { get; set; } = null!;
        public string Department { get; set; } = null!;
        public decimal CumulativeVariance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem StockItem { get; set; } = null!;
    }
}
