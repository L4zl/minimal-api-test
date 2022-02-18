using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlhistRevalAllocationTran
    {
        public long SlhistRevalAllocationTranId { get; set; }
        public long SystraderRevalAllocTypeId { get; set; }
        public long SlhistoricalCustomerTranId { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal AllocationValue { get; set; }
        public decimal CoreAllocationValue { get; set; }
        public decimal DocumentToBaseCurrencyRate { get; set; }
        public decimal ExchangeGainLoss { get; set; }
        public bool MultipleAllocation { get; set; }
        public bool NominalUpdated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTransactionMovedToHistory { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysaccountingPeriod? NominalAccountingPeriod { get; set; }
        public virtual SlhistoricalCustomerTran SlhistoricalCustomerTran { get; set; } = null!;
        public virtual SystraderRevalAllocType SystraderRevalAllocType { get; set; } = null!;
    }
}
