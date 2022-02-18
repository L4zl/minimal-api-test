using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemsupplierMapping
    {
        public long TemsupplierMappingId { get; set; }
        public long SupplierId { get; set; }
        public string Name { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string OriginatorsCode { get; set; } = null!;
        public long? DefaultNominalCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlsupplierAccount Supplier { get; set; } = null!;
    }
}
