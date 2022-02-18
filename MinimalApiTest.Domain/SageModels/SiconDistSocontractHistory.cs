using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSocontractHistory
    {
        public long SiconDistSocontractHistoryId { get; set; }
        public long? SiconDistSalesContractId { get; set; }
        public long? SiconDistSalesContractLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
