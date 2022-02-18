using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlhistRevalAllocationTran
    {
        public long PlhistRevalAllocationTranId { get; set; }
        public long SystraderRevalAllocTypeId { get; set; }
        public long PlhistoricalSupplierTranId { get; set; }
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
        public virtual PlhistoricalSupplierTran PlhistoricalSupplierTran { get; set; } = null!;
        public virtual SystraderRevalAllocType SystraderRevalAllocType { get; set; } = null!;
    }
}
