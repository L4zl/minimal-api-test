using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitTemplateLine
    {
        public long SiconKitTemplateLineId { get; set; }
        public long? SiconKitTemplateId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityToBuild { get; set; }
        public decimal? CostPercentage { get; set; }
        public bool? Deleted { get; set; }

        public virtual StockItem? Item { get; set; }
        public virtual SiconKitTemplate? SiconKitTemplate { get; set; }
    }
}
