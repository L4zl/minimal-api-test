using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Old200Bomallocation
    {
        public Old200Bomallocation()
        {
            BomallocComponents = new HashSet<BomallocComponent>();
            BomallocFinishedItems = new HashSet<BomallocFinishedItem>();
        }

        public long BomallocationId { get; set; }
        public string BomallocationName { get; set; } = null!;
        public long? WarehouseId { get; set; }
        public long BommakeupStockOptionId { get; set; }
        public long BommakeupSubAssOptionId { get; set; }
        public bool IsAllocationWithChanges { get; set; }
        public decimal TotalQtyForMake { get; set; }
        public bool IsClosed { get; set; }
        public DateTime AllocationDate { get; set; }
        public DateTime AllocationTime { get; set; }
        public string AllocatedBy { get; set; } = null!;
        public string UserAllocationReference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BommakeupStockOption BommakeupStockOption { get; set; } = null!;
        public virtual BommakeupSubAssOption BommakeupSubAssOption { get; set; } = null!;
        public virtual ICollection<BomallocComponent> BomallocComponents { get; set; }
        public virtual ICollection<BomallocFinishedItem> BomallocFinishedItems { get; set; }
    }
}
