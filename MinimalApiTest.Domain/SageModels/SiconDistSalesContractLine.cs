using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesContractLine
    {
        public long SiconDistSalesContractLineId { get; set; }
        public long? SiconDistSalesContractId { get; set; }
        public long? CustomerId { get; set; }
        public long? ItemId { get; set; }
        public string StockName { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal Balance { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public long? WarehouseId { get; set; }
    }
}
