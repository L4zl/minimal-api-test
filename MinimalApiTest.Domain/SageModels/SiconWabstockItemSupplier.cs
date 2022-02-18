using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockItemSupplier
    {
        public long SiconWabstockItemSupplierId { get; set; }
        public long StockItemSupplierId { get; set; }
        public bool? LabelRequiredOnPoreceive { get; set; }
    }
}
