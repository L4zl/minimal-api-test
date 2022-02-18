using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyslockDefinition
    {
        public long SyslockDefinitionId { get; set; }
        public string? OptionName { get; set; }
        public string? ClashingOption { get; set; }
        public string? ClashingData { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
