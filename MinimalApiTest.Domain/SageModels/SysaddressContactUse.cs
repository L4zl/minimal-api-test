using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaddressContactUse
    {
        public SysaddressContactUse()
        {
            SyscompanyContacts = new HashSet<SyscompanyContact>();
        }

        public long SysaddressContactUseId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SyscompanyContact> SyscompanyContacts { get; set; }
    }
}
