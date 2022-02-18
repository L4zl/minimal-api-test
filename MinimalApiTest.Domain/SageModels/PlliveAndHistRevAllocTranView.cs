using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlliveAndHistRevAllocTranView
    {
        public long PlsupplierAccountId { get; set; }
        public string TransactionReference { get; set; } = null!;
        public long TransactionUrn { get; set; }
        public DateTime EntryDate { get; set; }
        public long SystraderRevalAllocTypeId { get; set; }
        public decimal CoreAllocationValue { get; set; }
        public bool NominalUpdated { get; set; }
        public decimal ExchangeGainLoss { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public long PlrevalAllocationTranId { get; set; }
        public decimal DocumentToBaseCurrencyRate { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public string Location { get; set; } = null!;
    }
}
