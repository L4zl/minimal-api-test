using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrprescheduleMessage
    {
        public long SiMrprescheduleMessageId { get; set; }
        public long? NewSiconStockMovementsViewId { get; set; }
        public long? StockItem { get; set; }
        public long? Warehouse { get; set; }
        public DateTime? RescheduleDate { get; set; }
        public string? Message { get; set; }
        public string? Type { get; set; }
    }
}
