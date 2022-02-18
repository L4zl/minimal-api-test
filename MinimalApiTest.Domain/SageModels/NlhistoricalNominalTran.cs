using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlhistoricalNominalTran
    {
        public long NlhistoricalNominalTranId { get; set; }
        public long NldeletedNominalAccountId { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal GoodsValueInBaseCurrency { get; set; }
        public decimal GoodsValueInDocumentCurrency { get; set; }
        public long DocumentCurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public DateTime DeletionDate { get; set; }
        public string TransactionAnalysisCode { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SyscorrectionTranTypeId { get; set; }

        public virtual Syscurrency DocumentCurrency { get; set; } = null!;
        public virtual SysaccountingPeriod? SysaccountingPeriod { get; set; }
        public virtual SyscorrectionTranType SyscorrectionTranType { get; set; } = null!;
    }
}
