using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntryDescriptor
    {
        public PcprojectEntryDescriptor()
        {
            PcprojectEntries = new HashSet<PcprojectEntry>();
        }

        public long PcprojectEntryDescriptorId { get; set; }
        public string Key { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool RevenueType { get; set; }
        public string? TransactionType { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
    }
}
