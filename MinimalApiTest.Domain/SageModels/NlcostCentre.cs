using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlcostCentre
    {
        public NlcostCentre()
        {
            NlaccountNumberCostCentres = new HashSet<NlaccountNumberCostCentre>();
            NlnominalAccounts = new HashSet<NlnominalAccount>();
        }

        public long NlcostCentreId { get; set; }
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long EdufundTypeId { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;
        public string Institution { get; set; } = null!;
        public string ContactEmailAddress { get; set; } = null!;

        public virtual EdufundType EdufundType { get; set; } = null!;
        public virtual ICollection<NlaccountNumberCostCentre> NlaccountNumberCostCentres { get; set; }
        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
    }
}
