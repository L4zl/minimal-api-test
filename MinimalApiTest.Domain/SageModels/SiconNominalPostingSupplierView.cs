using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNominalPostingSupplierView
    {
        public long NlpostedNominalTranId { get; set; }
        public long Source { get; set; }
        public string Reference { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public decimal GoodsValueInBaseCurrency { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string? AccountNumber { get; set; }
        public string AccountName { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public string Name { get; set; } = null!;
    }
}
