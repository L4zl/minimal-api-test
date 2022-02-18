using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconReserveStockHistory
    {
        public long SiconReserveStockHistoryId { get; set; }
        public long? SiconReserveStockId { get; set; }
        public long? SiconReserveStockLineId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public int Type { get; set; }
        public long? TransactionId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string UserName { get; set; } = null!;
        public decimal Quantity { get; set; }
    }
}
