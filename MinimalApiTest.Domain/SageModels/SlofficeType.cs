using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlofficeType
    {
        public SlofficeType()
        {
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
        }

        public long SlofficeTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
    }
}
