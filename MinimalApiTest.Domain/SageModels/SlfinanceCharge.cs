using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlfinanceCharge
    {
        public SlfinanceCharge()
        {
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
        }

        public long SlfinanceChargeId { get; set; }
        public short FinanceChargeCode { get; set; }
        public decimal MonthlyPercentageCharge { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
    }
}
