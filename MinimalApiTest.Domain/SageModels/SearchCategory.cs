using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SearchCategory
    {
        public SearchCategory()
        {
            ProdGroupSearchCats = new HashSet<ProdGroupSearchCat>();
            SearchValues = new HashSet<SearchValue>();
            StockItemSearchCatVals = new HashSet<StockItemSearchCatVal>();
        }

        public long SearchCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<ProdGroupSearchCat> ProdGroupSearchCats { get; set; }
        public virtual ICollection<SearchValue> SearchValues { get; set; }
        public virtual ICollection<StockItemSearchCatVal> StockItemSearchCatVals { get; set; }
    }
}
