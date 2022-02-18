using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CustProdGroupDiscount
    {
        public long CustProdGroupDiscountId { get; set; }
        public long CustomerDiscountGroupId { get; set; }
        public long ProductGroupDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CustomerDiscountGroup CustomerDiscountGroup { get; set; } = null!;
        public virtual ProductGroupDiscount ProductGroupDiscount { get; set; } = null!;
    }
}
