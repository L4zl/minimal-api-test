using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscountryCodeTaxMask
    {
        public long SyscountryCodeTaxMaskId { get; set; }
        public long SyscountryCodeId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
    }
}
