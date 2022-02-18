using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxPeriodRateBalance
    {
        public SystaxPeriodRateBalance()
        {
            SystaxTrans = new HashSet<SystaxTran>();
        }

        public long SystaxPeriodRateBalanceId { get; set; }
        public long SystaxPeriodId { get; set; }
        public long SystaxRateId { get; set; }
        public DateTime? DateTaxReturnLastPrinted { get; set; }
        public DateTime? DateTaxTransactionsLastDeleted { get; set; }
        public decimal InputGoodsValue { get; set; }
        public decimal InputTaxValue { get; set; }
        public decimal OutputGoodsValue { get; set; }
        public decimal OutputTaxValue { get; set; }
        public DateTime? InputLastTransactionDate { get; set; }
        public DateTime? OutputLastTransactionDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystaxPeriod SystaxPeriod { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
        public virtual ICollection<SystaxTran> SystaxTrans { get; set; }
    }
}
