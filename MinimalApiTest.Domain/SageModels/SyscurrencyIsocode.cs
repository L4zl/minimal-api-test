using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscurrencyIsocode
    {
        public SyscurrencyIsocode()
        {
            Syscurrencies = new HashSet<Syscurrency>();
        }

        public long SyscurrencyIsocodeId { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Syscurrency> Syscurrencies { get; set; }
    }
}
