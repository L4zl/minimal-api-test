using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProdGroupSearchVal
    {
        public long ProdGroupSearchValId { get; set; }
        public long ProdGroupSearchCatId { get; set; }
        public long SearchValueId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProdGroupSearchCat ProdGroupSearchCat { get; set; } = null!;
        public virtual SearchValue SearchValue { get; set; } = null!;
    }
}
