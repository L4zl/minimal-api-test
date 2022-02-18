using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabitemSupplierBarcode
    {
        public long SiconWabitemSupplierBarcodeId { get; set; }
        public long? StockItemSupplier { get; set; }
        public long? ItemId { get; set; }
        public string? Barcode { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
