using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiBomandTemplateExplosionView
    {
        public long? ForeignId { get; set; }
        public string Type { get; set; } = null!;
        public long? FinishedItemId { get; set; }
        public string FinishedItemCode { get; set; } = null!;
        public long? ComponentItemId { get; set; }
        public string? ComponentItemCode { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? MultipleOfStockUom { get; set; }
        public long? BomitemTypeId { get; set; }
        public long? Built { get; set; }
    }
}
