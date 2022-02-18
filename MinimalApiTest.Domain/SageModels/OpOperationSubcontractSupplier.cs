using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OpOperationSubcontractSupplier
    {
        public OpOperationSubcontractSupplier()
        {
            OpOperationSubcontractQuantityBreaks = new HashSet<OpOperationSubcontractQuantityBreak>();
        }

        public long OpOperationSubcontractSupplierId { get; set; }
        public long OpOperationId { get; set; }
        public bool DefaultSupplier { get; set; }
        public long? SupplierId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string? OrderReference { get; set; }
        public int LeadTime { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public long MsmCostHeadingId { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string OrderDetails { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual OpOperation OpOperation { get; set; } = null!;
        public virtual ICollection<OpOperationSubcontractQuantityBreak> OpOperationSubcontractQuantityBreaks { get; set; }
    }
}
