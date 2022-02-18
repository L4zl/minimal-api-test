using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InternalArea
    {
        public long InternalAreaId { get; set; }
        public string InternalAreaName { get; set; } = null!;
        public bool ThisIsDefault { get; set; }
        public long NominalCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalAccount NominalCode { get; set; } = null!;
    }
}
