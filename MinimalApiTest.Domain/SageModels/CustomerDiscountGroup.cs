using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CustomerDiscountGroup
    {
        public CustomerDiscountGroup()
        {
            CustProdGroupDiscounts = new HashSet<CustProdGroupDiscount>();
            CustStockItemDiscounts = new HashSet<CustStockItemDiscount>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
        }

        public long CustomerDiscountGroupId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool? IsSingleCustomerGroup { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<CustProdGroupDiscount> CustProdGroupDiscounts { get; set; }
        public virtual ICollection<CustStockItemDiscount> CustStockItemDiscounts { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
    }
}
