using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockCountSheetItem
    {
        public long SiconWabstockCountSheetItemId { get; set; }
        public long? StocktakeCountShtItemId { get; set; }
        public bool Processed { get; set; }
        public bool RemoveProcessed { get; set; }
        public decimal ToSwapQuantity { get; set; }
        public decimal SwapUnitCost { get; set; }
    }
}
