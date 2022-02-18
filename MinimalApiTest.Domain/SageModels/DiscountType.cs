using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            StockItemDiscounts = new HashSet<StockItemDiscount>();
        }

        public long DiscountTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItemDiscount> StockItemDiscounts { get; set; }
    }
}
