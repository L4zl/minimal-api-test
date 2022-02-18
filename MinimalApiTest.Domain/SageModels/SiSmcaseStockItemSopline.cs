using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseStockItemSopline
    {
        public long SiSmcaseStockItemSoplineId { get; set; }
        public long SiSmcaseStockItemId { get; set; }
        public long SoporderReturnLineId { get; set; }
    }
}
