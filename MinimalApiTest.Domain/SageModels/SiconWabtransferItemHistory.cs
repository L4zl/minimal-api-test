using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabtransferItemHistory
    {
        public long SiconWabtransferItemHistoryId { get; set; }
        public DateTime? HistoryDate { get; set; }
        public long TransactionHistoryId { get; set; }
        public long SiconWabtransferItemId { get; set; }
    }
}
