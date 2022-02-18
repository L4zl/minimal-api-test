using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyspaymentTermsBasis
    {
        public SyspaymentTermsBasis()
        {
            PlpendSupplierAccounts = new HashSet<PlpendSupplierAccount>();
            Plsettings = new HashSet<Plsetting>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
            Slsettings = new HashSet<Slsetting>();
        }

        public long SyspaymentTermsBasisId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlpendSupplierAccount> PlpendSupplierAccounts { get; set; }
        public virtual ICollection<Plsetting> Plsettings { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
        public virtual ICollection<Slsetting> Slsettings { get; set; }
    }
}
