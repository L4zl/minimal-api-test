using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlpendCustomerBatch
    {
        public SlpendCustomerBatch()
        {
            SlpendCustomerBatchTrans = new HashSet<SlpendCustomerBatchTran>();
        }

        public long SlpendCustomerBatchId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public string BatchTitle { get; set; } = null!;
        public short NumberOfTransactionsInBatch { get; set; }
        public decimal BatchTotalValue { get; set; }
        public DateTime BatchCreatedDate { get; set; }
        public DateTime? BatchLastAmendedDate { get; set; }
        public string BatchCreatedByUserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public decimal ActualBatchTotalValue { get; set; }
        public short ActualNumberOfTransInBatch { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystraderTranType SystraderTranType { get; set; } = null!;
        public virtual ICollection<SlpendCustomerBatchTran> SlpendCustomerBatchTrans { get; set; }
    }
}
