using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpsuggestedStockTransfer
    {
        public long SiMrpsuggestedStockTransferId { get; set; }
        public string? TransferNumber { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public int? Type { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
