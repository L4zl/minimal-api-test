using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeLiveBinItem
    {
        public long StocktakeLiveBinItemId { get; set; }
        public long StocktakeId { get; set; }
        public long StocktakeItemId { get; set; }
        public long BinItemId { get; set; }

        public virtual Stocktake Stocktake { get; set; } = null!;
        public virtual StocktakeItem StocktakeItem { get; set; } = null!;
    }
}
