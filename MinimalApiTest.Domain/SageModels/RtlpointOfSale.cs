using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlpointOfSale
    {
        public long PosId { get; set; }
        public long StoreId { get; set; }
        public string Slaccount { get; set; } = null!;
        public string? PosType { get; set; }
        public string? Location { get; set; }
        public string? Version { get; set; }
        public string? Description { get; set; }
        public string? DataPath { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
