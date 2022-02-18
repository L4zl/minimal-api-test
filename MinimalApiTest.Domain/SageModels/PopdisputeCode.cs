using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopdisputeCode
    {
        public PopdisputeCode()
        {
            PopinvCredDisputes = new HashSet<PopinvCredDispute>();
        }

        public long PopdisputeCodeId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool AllowInvCredWriteOff { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PopinvCredDispute> PopinvCredDisputes { get; set; }
    }
}
