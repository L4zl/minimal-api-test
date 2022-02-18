using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmsubCategoryKitLine
    {
        public long SiconHmsubCategoryKitLineId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? SiconFixedAssetId { get; set; }
        public int LineTypeId { get; set; }
        public long? RecommendedCategoryId { get; set; }
        public long? RecommendedSubCategoryId { get; set; }
        public long? RecommendedStockItemId { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Mandatory { get; set; }
        public bool? IsUserQuantityEntry { get; set; }
        public long? RecommendedChargeItemId { get; set; }
        public long? RecommendedFixedAssetId { get; set; }
    }
}
