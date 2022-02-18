using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockItemUombarcode
    {
        public long SiconWabstockItemUombarcodeId { get; set; }
        public long? ItemId { get; set; }
        public long? StockItemUnitId { get; set; }
        public string? Barcode { get; set; }
    }
}
