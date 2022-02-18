using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProductGroupDiscount
    {
        public ProductGroupDiscount()
        {
            CustProdGroupDiscounts = new HashSet<CustProdGroupDiscount>();
            ProdGroupQtyDiscBreaks = new HashSet<ProdGroupQtyDiscBreak>();
        }

        public long ProductGroupDiscountId { get; set; }
        public string Name { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual ICollection<CustProdGroupDiscount> CustProdGroupDiscounts { get; set; }
        public virtual ICollection<ProdGroupQtyDiscBreak> ProdGroupQtyDiscBreaks { get; set; }
    }
}
