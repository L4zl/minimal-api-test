using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsconfigurableTerm
    {
        public long TsconfigurableTermId { get; set; }
        public string ConfiguredTerm { get; set; } = null!;
        public string DefaultTerm { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
