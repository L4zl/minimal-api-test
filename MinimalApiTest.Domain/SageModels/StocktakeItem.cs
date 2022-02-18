using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeItem
    {
        public StocktakeItem()
        {
            StocktakeLiveBinItems = new HashSet<StocktakeLiveBinItem>();
        }

        public long StocktakeItemId { get; set; }
        public long StocktakeId { get; set; }
        public bool Selected { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public decimal HoldingValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Details { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Stocktake Stocktake { get; set; } = null!;
        public virtual ICollection<StocktakeLiveBinItem> StocktakeLiveBinItems { get; set; }
    }
}
