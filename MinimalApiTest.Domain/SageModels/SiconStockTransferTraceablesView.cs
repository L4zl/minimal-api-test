using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTransferTraceablesView
    {
        public long SiconStockTransferId { get; set; }
        public long SiconStockTransferItemId { get; set; }
        public string? Streference { get; set; }
        public long? TraceableTypeId { get; set; }
        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public long TraceableBinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public decimal DespatchQuantity { get; set; }
        public decimal ReceiptQuantity { get; set; }
    }
}
