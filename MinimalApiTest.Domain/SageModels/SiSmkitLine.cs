using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmkitLine
    {
        public long? SiSmkitLineId { get; set; }
        public long? SiSmkitId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
    }
}
