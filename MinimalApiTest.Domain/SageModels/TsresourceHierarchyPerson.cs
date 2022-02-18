using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceHierarchyPerson
    {
        public long TsresourceHierarchyPersonId { get; set; }
        public long TsresourceHierarchyId { get; set; }
        public long TspersonId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Tsperson Tsperson { get; set; } = null!;
        public virtual TsresourceHierarchy TsresourceHierarchy { get; set; } = null!;
    }
}
