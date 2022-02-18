using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconArchivedStkTransferTran
    {
        public long SiconArchivedStkTransfTransId { get; set; }
        public long? SiconArchivedStockTransItemId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public int Type { get; set; }
    }
}
