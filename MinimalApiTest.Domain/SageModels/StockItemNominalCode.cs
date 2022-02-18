using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemNominalCode
    {
        public long StockItemNominalCodeId { get; set; }
        public long ItemId { get; set; }
        public long NominalCodeId { get; set; }
        public long NominalUsageId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual NlnominalAccount NominalCode { get; set; } = null!;
        public virtual NominalUsage NominalUsage { get; set; } = null!;
    }
}
