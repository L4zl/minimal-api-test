using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockItem
    {
        public long SiconStockItemId { get; set; }
        public long? ItemId { get; set; }
        public bool InspectionRequiredWhenReceive { get; set; }
        public bool StockTransferAutoIssueOnRec { get; set; }
    }
}
