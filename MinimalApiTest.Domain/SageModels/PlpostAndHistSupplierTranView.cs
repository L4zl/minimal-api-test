using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpostAndHistSupplierTranView
    {
        public long PlpostedSupplierTranId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public decimal? GoodsValueInBaseCurrency { get; set; }
        public string Location { get; set; } = null!;
    }
}
