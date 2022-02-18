using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemPoporderLine
    {
        public long PcprojectItemPoporderLineId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public long PcprojectItemId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
    }
}
