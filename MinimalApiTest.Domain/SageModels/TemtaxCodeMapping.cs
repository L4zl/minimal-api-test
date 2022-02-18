using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemtaxCodeMapping
    {
        public long TemtaxCodeMappingId { get; set; }
        public long? InternalTaxCodeId { get; set; }
        public long? TemstandardTaxCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystaxRate? InternalTaxCode { get; set; }
        public virtual TemstandardTaxCode? TemstandardTaxCode { get; set; }
    }
}
