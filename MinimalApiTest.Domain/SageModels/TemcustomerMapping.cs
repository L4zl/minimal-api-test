using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemcustomerMapping
    {
        public long TemcustomerMappingId { get; set; }
        public long CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string OriginatorsCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerAccount Customer { get; set; } = null!;
    }
}
