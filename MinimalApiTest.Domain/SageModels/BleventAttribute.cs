using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BleventAttribute
    {
        public long BleventAttributeId { get; set; }
        public long BleventId { get; set; }
        public string Name { get; set; } = null!;
        public string DataTypeName { get; set; } = null!;
        public string Value { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Blevent Blevent { get; set; } = null!;
    }
}
