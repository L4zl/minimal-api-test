using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsnoDocumentsPlview
    {
        public long PlpostedSupplierTranId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public string SystraderTranTypeName { get; set; } = null!;
        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public string QueryCode { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }
}
