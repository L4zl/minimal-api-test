using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ConfigurableName
    {
        public long ConfigurableNameId { get; set; }
        public string ConfiguredName { get; set; } = null!;
        public string DefaultName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
