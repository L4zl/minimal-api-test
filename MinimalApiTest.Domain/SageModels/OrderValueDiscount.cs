using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OrderValueDiscount
    {
        public OrderValueDiscount()
        {
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            ValueDiscountBreaks = new HashSet<ValueDiscountBreak>();
        }

        public long OrderValueDiscountId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? CurrencyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency? Currency { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<ValueDiscountBreak> ValueDiscountBreaks { get; set; }
    }
}
