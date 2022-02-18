using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodExchangeRate
    {
        public long SysperiodExchangeRate1 { get; set; }
        public long SyscurrencyId { get; set; }
        public byte CurrencyType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal OneUnitEquals { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency Syscurrency { get; set; } = null!;
    }
}
