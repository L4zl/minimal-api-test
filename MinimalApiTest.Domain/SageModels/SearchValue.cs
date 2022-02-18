using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SearchValue
    {
        public SearchValue()
        {
            ProdGroupSearchVals = new HashSet<ProdGroupSearchVal>();
            StockItemSearchCatVals = new HashSet<StockItemSearchCatVal>();
        }

        public long SearchValueId { get; set; }
        public string Name { get; set; } = null!;
        public long SearchCategoryId { get; set; }
        public bool NoneValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SearchCategory SearchCategory { get; set; } = null!;
        public virtual ICollection<ProdGroupSearchVal> ProdGroupSearchVals { get; set; }
        public virtual ICollection<StockItemSearchCatVal> StockItemSearchCatVals { get; set; }
    }
}
