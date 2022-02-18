using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlvariantStructure
    {
        public long PrdHierNodeId { get; set; }
        public int Dimes { get; set; }
        public int Dime1 { get; set; }
        public int? Dime2 { get; set; }
        public int? Dime3 { get; set; }
        public string? SageProductGroupCode { get; set; }
        public long? DimeSetId1 { get; set; }
        public long? DimeSetId2 { get; set; }
        public long? DimeSetId3 { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long VarStructId { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
