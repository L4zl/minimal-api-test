using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabbinStockDate
    {
        public long SiconWabbinStockDateId { get; set; }
        public long BinItemId { get; set; }
        public DateTime? StockDate { get; set; }
        public decimal Quantity { get; set; }
    }
}
