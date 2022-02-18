using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPurchaseContractLine
    {
        public long SiconDistContractLineId { get; set; }
        public long? SiconDistPurchaseContractId { get; set; }
        public long? SupplierId { get; set; }
        public long? ItemId { get; set; }
        public string StockName { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool Deleted { get; set; }
        public long? WarehouseId { get; set; }
    }
}
