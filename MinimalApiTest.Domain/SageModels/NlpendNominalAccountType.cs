using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalAccountType
    {
        public NlpendNominalAccountType()
        {
            NlpendNominalAccounts = new HashSet<NlpendNominalAccount>();
        }

        public long NlpendNominalAccountTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlpendNominalAccount> NlpendNominalAccounts { get; set; }
    }
}
