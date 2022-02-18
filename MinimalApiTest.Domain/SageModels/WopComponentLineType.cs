using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopComponentLineType
    {
        public WopComponentLineType()
        {
            WopComponentLines = new HashSet<WopComponentLine>();
        }

        public long WopComponentLineTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<WopComponentLine> WopComponentLines { get; set; }
    }
}
