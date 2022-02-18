using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtldispatch
    {
        public long DispatchId { get; set; }
        public DateTime? DispatchDate { get; set; }
        public long HierNodeId { get; set; }
        public long StoreId { get; set; }
        public string? DispatchUser { get; set; }
        public string? DispatchRef { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
