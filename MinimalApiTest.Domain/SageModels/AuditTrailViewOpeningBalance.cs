using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AuditTrailViewOpeningBalance
    {
        public long SysauditTrailId { get; set; }
        public long SysauditTrailEntryTypeId { get; set; }
        public string TransactionType { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string EntrySourceName { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string BatchReference { get; set; } = null!;
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime? PostedDate { get; set; }
        public decimal TransactionToBaseExchangeRate { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public decimal NetValue { get; set; }
        public long? CbaccountId { get; set; }
    }
}
