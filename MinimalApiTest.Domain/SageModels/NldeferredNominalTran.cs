using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NldeferredNominalTran
    {
        public long NldeferredNominalTranId { get; set; }
        public long Source { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountCostCentre { get; set; } = null!;
        public string AccountDepartment { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public decimal GoodsValueInBaseCurrency { get; set; }
        public decimal GoodsValueInDocumentCurrency { get; set; }
        public long DocumentCurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public DateTime PostedDate { get; set; }
        public string TransactionAnalysisCode { get; set; } = null!;
        public bool ReadyToProcess { get; set; }
        public bool CreateAuditTrail { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long NominalPeriodModule { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SyscorrectionTranTypeId { get; set; }

        public virtual Syscurrency DocumentCurrency { get; set; } = null!;
        public virtual NlnominalTranType NlnominalTranType { get; set; } = null!;
        public virtual Sysmodule NominalPeriodModuleNavigation { get; set; } = null!;
        public virtual Sysmodule SourceNavigation { get; set; } = null!;
        public virtual SyscorrectionTranType SyscorrectionTranType { get; set; } = null!;
    }
}
