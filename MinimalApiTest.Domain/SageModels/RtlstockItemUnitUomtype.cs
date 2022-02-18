using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItemUnitUomtype
    {
        public long StockItemUnitUomtypeId { get; set; }
        public long StockItemUnitId { get; set; }
        public long UnitOfMeasureTypeId { get; set; }
        public long StockItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
