using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperationSubcontractSupplier
    {
        public BomOperationSubcontractSupplier()
        {
            BomOperationSubcontractQuantityBreaks = new HashSet<BomOperationSubcontractQuantityBreak>();
        }

        public long BomOperationSubcontractSupplierId { get; set; }
        public long BomOperationId { get; set; }
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

        public virtual BomOperation BomOperation { get; set; } = null!;
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual ICollection<BomOperationSubcontractQuantityBreak> BomOperationSubcontractQuantityBreaks { get; set; }
    }
}
