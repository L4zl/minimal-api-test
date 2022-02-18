using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysexchangeRateAmendType
    {
        public SysexchangeRateAmendType()
        {
            Syscurrencies = new HashSet<Syscurrency>();
        }

        public long SysexchangeRateAmendTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Syscurrency> Syscurrencies { get; set; }
    }
}
