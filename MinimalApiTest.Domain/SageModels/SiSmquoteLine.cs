using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmquoteLine
    {
        public long SiSmquoteLineId { get; set; }
        public long SiSmquoteId { get; set; }
        public string? Description { get; set; }
        public long? ItemId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DefaultTotalPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? TypeId { get; set; }
    }
}
