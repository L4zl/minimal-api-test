using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTransferItemTran
    {
        public long SiconStockTransferItemTransId { get; set; }
        public long? SiconStockTransferItemId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public int? Type { get; set; }
    }
}
