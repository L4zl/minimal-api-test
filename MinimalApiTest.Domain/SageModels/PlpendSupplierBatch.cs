using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpendSupplierBatch
    {
        public PlpendSupplierBatch()
        {
            PlpendSupplierBatchTrans = new HashSet<PlpendSupplierBatchTran>();
        }

        public long PlpendSupplierBatchId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public string BatchTitle { get; set; } = null!;
        public short NumberOfTransactionsInBatch { get; set; }
        public decimal BatchTotalValue { get; set; }
        public DateTime BatchCreatedDate { get; set; }
        public DateTime? BatchLastAmendedDate { get; set; }
        public string BatchCreatedByUserName { get; set; } = null!;
        public short ActualNumberOfTransInBatch { get; set; }
        public decimal ActualBatchTotalValue { get; set; }
        public int UserNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystraderTranType SystraderTranType { get; set; } = null!;
        public virtual ICollection<PlpendSupplierBatchTran> PlpendSupplierBatchTrans { get; set; }
    }
}
