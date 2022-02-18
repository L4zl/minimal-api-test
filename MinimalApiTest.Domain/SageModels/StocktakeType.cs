using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeType
    {
        public StocktakeType()
        {
            Stocktakes = new HashSet<Stocktake>();
        }

        public long StocktakeTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Stocktake> Stocktakes { get; set; }
    }
}
