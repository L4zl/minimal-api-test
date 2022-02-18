using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeStatus
    {
        public StocktakeStatus()
        {
            Stocktakes = new HashSet<Stocktake>();
        }

        public long StocktakeStatusId { get; set; }
        public string StocktakeStatusName { get; set; } = null!;

        public virtual ICollection<Stocktake> Stocktakes { get; set; }
    }
}
