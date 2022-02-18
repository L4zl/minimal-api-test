using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseContactAddress
    {
        public long MseContactAddressId { get; set; }
        public long MseAddressId { get; set; }
        public long MseContactId { get; set; }
        public bool IsPreferred { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseAddress MseAddress { get; set; } = null!;
        public virtual MseContact MseContact { get; set; } = null!;
    }
}
