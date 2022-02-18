using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopOrder
    {
        public WopOrder()
        {
            BomAllocationWopOrderLinks = new HashSet<BomAllocationWopOrderLink>();
            WopBuilds = new HashSet<WopBuild>();
            WopComponentLines = new HashSet<WopComponentLine>();
            WopOrderLinkParentWopOrders = new HashSet<WopOrderLink>();
            WopOrderLinkWopOrders = new HashSet<WopOrderLink>();
        }

        public long WopOrderId { get; set; }
        public string WopNumber { get; set; } = null!;
        public long WopOrderTypeId { get; set; }
        public long? BomRecordId { get; set; }
        public decimal QuantityRequired { get; set; }
        public decimal QuantityCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public long WarehouseId { get; set; }
        public bool BomModified { get; set; }
        /// <summary>
        /// Holds the DB Key of the BomAllocation if this order relates to a BOM Allocation
        /// </summary>
        public long? BomAllocationId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomAllocation? BomAllocation { get; set; }
        public virtual BomRecord? BomRecord { get; set; }
        public virtual WopOrderType WopOrderType { get; set; } = null!;
        public virtual ICollection<BomAllocationWopOrderLink> BomAllocationWopOrderLinks { get; set; }
        public virtual ICollection<WopBuild> WopBuilds { get; set; }
        public virtual ICollection<WopComponentLine> WopComponentLines { get; set; }
        public virtual ICollection<WopOrderLink> WopOrderLinkParentWopOrders { get; set; }
        public virtual ICollection<WopOrderLink> WopOrderLinkWopOrders { get; set; }
    }
}
