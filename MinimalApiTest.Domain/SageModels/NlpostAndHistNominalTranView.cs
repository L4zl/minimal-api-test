using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpostAndHistNominalTranView
    {
        public long NlpostedNominalTranId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal GoodsValueInBaseCurrency { get; set; }
        public string Reference { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public string Location { get; set; } = null!;
    }
}
