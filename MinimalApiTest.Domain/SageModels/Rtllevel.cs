using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtllevel
    {
        public long LevelId { get; set; }
        public string LevelName { get; set; } = null!;
        public bool IsStore { get; set; }
        public string? Description { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? LevelSeq { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
