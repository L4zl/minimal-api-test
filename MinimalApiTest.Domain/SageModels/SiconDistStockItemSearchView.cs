using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockItemSearchView
    {
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PartNumber { get; set; } = null!;
        public decimal? FreeStock { get; set; }
        public bool? Discontinued { get; set; }
        public bool? ItemSuperseded { get; set; }
        public long? SupersededItemId { get; set; }
    }
}
