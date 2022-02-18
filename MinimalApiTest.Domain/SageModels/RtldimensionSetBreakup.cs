using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtldimensionSetBreakup
    {
        public long DimeSetSubId { get; set; }
        public long DimeSetId { get; set; }
        public long DimeId { get; set; }
        public long DimeSubId { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
