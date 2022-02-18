using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstocktakeTraceItem
    {
        public long SiconWabstocktakeTraceItemId { get; set; }
        public long StocktakeCountShtItemId { get; set; }
        public string? IdentificationNo { get; set; }
        public decimal? ActualQuantity { get; set; }
    }
}
