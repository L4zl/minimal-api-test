using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeSelector
    {
        public StocktakeSelector()
        {
            Stocktakes = new HashSet<Stocktake>();
        }

        public long StocktakeSelectorId { get; set; }
        public string StocktakeSelectorName { get; set; } = null!;

        public virtual ICollection<Stocktake> Stocktakes { get; set; }
    }
}
