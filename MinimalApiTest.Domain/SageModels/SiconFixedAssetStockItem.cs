using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetStockItem
    {
        public long SiconFixedAssetStockItemId { get; set; }
        public long? ItemId { get; set; }
        public long? SubCategoryId { get; set; }
    }
}
