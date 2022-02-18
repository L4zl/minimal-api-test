using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStcanPreallocateView
    {
        public long ItemId { get; set; }
        public string StockCode { get; set; } = null!;
        public string? DocumentNo { get; set; }
        public long SiconStockTransferItemId { get; set; }
        public DateTime? DespatchDate { get; set; }
        public decimal? Quantity { get; set; }
        public long? WarehouseId { get; set; }
    }
}
