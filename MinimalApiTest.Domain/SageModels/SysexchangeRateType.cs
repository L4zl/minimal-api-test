using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysexchangeRateType
    {
        public SysexchangeRateType()
        {
            PlpendSupplierAccounts = new HashSet<PlpendSupplierAccount>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
            Syscurrencies = new HashSet<Syscurrency>();
        }

        public long SysexchangeRateTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlpendSupplierAccount> PlpendSupplierAccounts { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
        public virtual ICollection<Syscurrency> Syscurrencies { get; set; }
    }
}
