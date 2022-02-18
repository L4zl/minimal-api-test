using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockMatrixSopdespatch
    {
        public long SiDistStockMatrixSopdespatchId { get; set; }
        public string DespatchReceiptNote { get; set; } = null!;
        public long? SiDistStockItemGroupId { get; set; }
        public long? ItemId { get; set; }
        public decimal LineQuantity { get; set; }
        public int Yindex { get; set; }
        public int Xindex { get; set; }
        public string Yattribute { get; set; } = null!;
        public long? SoporderReturnLineId { get; set; }
    }
}
