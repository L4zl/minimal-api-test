using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountStatus
    {
        public SysaccountStatus()
        {
            Cbaccounts = new HashSet<Cbaccount>();
            NlnominalAccounts = new HashSet<NlnominalAccount>();
            NlpendNominalAccounts = new HashSet<NlpendNominalAccount>();
            NlreportCategoryBudgets = new HashSet<NlreportCategoryBudget>();
            PlpendSupplierAccounts = new HashSet<PlpendSupplierAccount>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
        }

        public long SysaccountStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Cbaccount> Cbaccounts { get; set; }
        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
        public virtual ICollection<NlpendNominalAccount> NlpendNominalAccounts { get; set; }
        public virtual ICollection<NlreportCategoryBudget> NlreportCategoryBudgets { get; set; }
        public virtual ICollection<PlpendSupplierAccount> PlpendSupplierAccounts { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
    }
}
