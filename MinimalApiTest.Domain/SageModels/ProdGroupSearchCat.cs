using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProdGroupSearchCat
    {
        public ProdGroupSearchCat()
        {
            ProdGroupSearchVals = new HashSet<ProdGroupSearchVal>();
        }

        public long ProdGroupSearchCatId { get; set; }
        public long ProductGroupId { get; set; }
        public long SearchCategoryId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual SearchCategory SearchCategory { get; set; } = null!;
        public virtual ICollection<ProdGroupSearchVal> ProdGroupSearchVals { get; set; }
    }
}
