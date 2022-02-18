using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspaymentMethod
    {
        public TspaymentMethod()
        {
            TsclaimSheets = new HashSet<TsclaimSheet>();
            TshumanResources = new HashSet<TshumanResource>();
        }

        public long TspaymentMethodId { get; set; }
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
    }
}
