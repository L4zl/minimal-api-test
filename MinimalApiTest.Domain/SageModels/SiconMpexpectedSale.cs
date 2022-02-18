using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpexpectedSale
    {
        public long SiconMpexpectedSalesId { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Quantity { get; set; }
    }
}
