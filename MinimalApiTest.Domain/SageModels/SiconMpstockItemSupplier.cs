using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpstockItemSupplier
    {
        public long SiconMpstockItemSupplierId { get; set; }
        public long StockItemSupplierId { get; set; }
        public decimal? UsualOrderQuantity { get; set; }
        public decimal? MinOrderQuantity { get; set; }
    }
}
