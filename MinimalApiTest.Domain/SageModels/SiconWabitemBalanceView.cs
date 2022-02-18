using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabitemBalanceView
    {
        public long ItemId { get; set; }
        public decimal? QtyInStock { get; set; }
        public decimal? AllocatedQty { get; set; }
        public long WarehouseId { get; set; }
        public decimal QuantityReserved { get; set; }
    }
}
