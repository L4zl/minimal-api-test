using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSpecialPriceOverrideItem
    {
        public long SpecialPriceOverrideItemId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
