using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysconfigAssistant
    {
        public SysconfigAssistant()
        {
            InverseParentSysconfigAssistant = new HashSet<SysconfigAssistant>();
        }

        public long SysconfigAssistantId { get; set; }
        public string TileIdentifier { get; set; } = null!;
        public int TileStatus { get; set; }
        public string InternalState { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string TileName { get; set; } = null!;
        public string TileDescription { get; set; } = null!;
        public long? ParentSysconfigAssistantId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysconfigAssistant? ParentSysconfigAssistant { get; set; }
        public virtual ICollection<SysconfigAssistant> InverseParentSysconfigAssistant { get; set; }
    }
}
