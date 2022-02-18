using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTransferHistory
    {
        public long SiconStockTransferHistoryId { get; set; }
        public long SiconStockTransferId { get; set; }
        public int HistoryType { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public string Username { get; set; } = null!;

        public virtual SiconStockTransfer SiconStockTransfer { get; set; } = null!;
    }
}
