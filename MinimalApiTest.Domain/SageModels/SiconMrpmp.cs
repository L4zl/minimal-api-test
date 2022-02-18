using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpmp
    {
        public long SiconMrpmpsid { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? DateRequired { get; set; }
    }
}
