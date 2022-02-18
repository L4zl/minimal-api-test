using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPocontractHistory
    {
        public long SiconDistPocontractHistoryId { get; set; }
        public long? SiconDistPurchaseContractId { get; set; }
        public long? SiconDistContractLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
