using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SltransactionSummary
    {
        public long SlcustomerAccountId { get; set; }
        public long SysTraderTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? InvoiceValueInBase { get; set; }
        public decimal? InvoiceValue { get; set; }
        public decimal? CreditNoteValueInBase { get; set; }
        public decimal? CreditNoteValue { get; set; }
        public decimal? CashValueInBase { get; set; }
        public decimal? CashValue { get; set; }
        public decimal? ExchangeRateGainLoss { get; set; }
    }
}
