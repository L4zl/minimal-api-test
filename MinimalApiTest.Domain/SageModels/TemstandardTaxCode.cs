using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemstandardTaxCode
    {
        public TemstandardTaxCode()
        {
            TemtaxCodeMappings = new HashSet<TemtaxCodeMapping>();
        }

        public long TemstandardTaxCodeId { get; set; }
        public string Name { get; set; } = null!;
        public long? CountryCodeId { get; set; }
        public long TemcodePageId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode? CountryCode { get; set; }
        public virtual ICollection<TemtaxCodeMapping> TemtaxCodeMappings { get; set; }
    }
}
