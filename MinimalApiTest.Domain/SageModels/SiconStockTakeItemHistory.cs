using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTakeItemHistory
    {
        public long SiconStockTakeItemHistoryId { get; set; }
        public long StockTakeId { get; set; }
        public bool? Selected { get; set; }
        public decimal? AverageBuyingPrice { get; set; }
        public decimal? HoldingValue { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public string? Details { get; set; }
        public string? Deleted { get; set; }
    }
}
