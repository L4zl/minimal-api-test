using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbaccountType
    {
        public CbaccountType()
        {
            Cbaccounts = new HashSet<Cbaccount>();
        }

        public long CbaccountTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Cbaccount> Cbaccounts { get; set; }
    }
}
