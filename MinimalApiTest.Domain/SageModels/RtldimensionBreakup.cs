using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtldimensionBreakup
    {
        public long DimeSubId { get; set; }
        public long DimeId { get; set; }
        public string? Description { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long DimeNumber { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
