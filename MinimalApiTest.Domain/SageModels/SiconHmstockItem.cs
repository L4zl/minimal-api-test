using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmstockItem
    {
        public long SiconHmstockItemId { get; set; }
        public long StockItemId { get; set; }
        public bool? AddToLastInvoice { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
