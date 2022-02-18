using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItemUnit
    {
        public long StockItemUnitId { get; set; }
        public long ItemId { get; set; }
        public long UnitId { get; set; }
        public decimal MultipleOfBaseUnit { get; set; }
        public bool UseOwnPrice { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal UnitPrecision { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
