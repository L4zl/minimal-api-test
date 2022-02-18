using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtldimensionSet
    {
        public long DimeSetId { get; set; }
        public long DimeId { get; set; }
        public string? Caption { get; set; }
        public string? Description { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
