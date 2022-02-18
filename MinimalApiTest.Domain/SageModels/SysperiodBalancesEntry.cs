using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodBalancesEntry
    {
        public long SysperiodBalancesEntryId { get; set; }
        public long SysperiodBalancesLedgerId { get; set; }
        public long AccountId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public decimal ValueBefore { get; set; }
        public decimal ValueAfter { get; set; }
        public string NameOfTable { get; set; } = null!;
        public string NameOfField { get; set; } = null!;
        public string ReasonForCharge { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
