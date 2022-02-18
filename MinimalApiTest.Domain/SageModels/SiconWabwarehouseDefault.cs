using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabwarehouseDefault
    {
        public long SiconWabwarehouseDefaultsId { get; set; }
        public long WarehouseId { get; set; }
        public string? LabelPrinter { get; set; }
        public string? PackingListPrinter { get; set; }
        public string? DespatchNotePrinter { get; set; }
        public string? InvoicePrinter { get; set; }
    }
}
