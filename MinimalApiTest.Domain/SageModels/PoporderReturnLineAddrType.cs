using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderReturnLineAddrType
    {
        public PoporderReturnLineAddrType()
        {
            PopordReturnLineDelAddrArches = new HashSet<PopordReturnLineDelAddrArch>();
            PopordReturnLineDelAddresses = new HashSet<PopordReturnLineDelAddress>();
        }

        public long PoporderReturnLineAddrTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopordReturnLineDelAddrArch> PopordReturnLineDelAddrArches { get; set; }
        public virtual ICollection<PopordReturnLineDelAddress> PopordReturnLineDelAddresses { get; set; }
    }
}
