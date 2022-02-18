using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistRapidOrderEntry
    {
        public long SiconDistRapidOrderEntryId { get; set; }
        public long? StockItemId { get; set; }
        public string? Description { get; set; }
        public bool? UseDescription { get; set; }
        public string? PickListComment { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
