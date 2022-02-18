using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlhierarchyEvent
    {
        public long HierarchyEventId { get; set; }
        public long EventTypeId { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public string? Description { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
