using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillLinePosting
    {
        public long BlbillLinePostingId { get; set; }
        public long BlbillLineId { get; set; }
        public long PcprojectEntryPostingId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlbillLine BlbillLine { get; set; } = null!;
        public virtual PcprojectEntryPosting PcprojectEntryPosting { get; set; } = null!;
    }
}
