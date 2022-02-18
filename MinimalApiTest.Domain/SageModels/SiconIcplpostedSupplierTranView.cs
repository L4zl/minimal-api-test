using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcplpostedSupplierTranView
    {
        public long PlpostedSupplierTranId { get; set; }
        public string TransactionReference { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public long SystraderTranTypeId { get; set; }
        public long? PlSupplierAccountId { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? SupplierAccountName { get; set; }
    }
}
