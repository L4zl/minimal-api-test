using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableBinItem
    {
        public TraceableBinItem()
        {
            SiWosubContractDespatchLines = new HashSet<SiWosubContractDespatchLine>();
            TraceCountSheetItems = new HashSet<TraceCountSheetItem>();
            TracePopinvCredLines = new HashSet<TracePopinvCredLine>();
            TracePoprcptRtnLines = new HashSet<TracePoprcptRtnLine>();
            TraceSopdespRcptLines = new HashSet<TraceSopdespRcptLine>();
            TraceSopinvCredLines = new HashSet<TraceSopinvCredLine>();
            TraceableAllocationBals = new HashSet<TraceableAllocationBal>();
            TraceableMovementBals = new HashSet<TraceableMovementBal>();
        }

        public long TraceableBinItemId { get; set; }
        public long TraceableItemId { get; set; }
        public long BinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public long? WarehouseItemId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public decimal GoodsInQuantity { get; set; }
        public decimal GoodsOutQuantity { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public long AllocationPriority { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BinItem BinItem { get; set; } = null!;
        public virtual TraceableItem TraceableItem { get; set; } = null!;
        public virtual ICollection<SiWosubContractDespatchLine> SiWosubContractDespatchLines { get; set; }
        public virtual ICollection<TraceCountSheetItem> TraceCountSheetItems { get; set; }
        public virtual ICollection<TracePopinvCredLine> TracePopinvCredLines { get; set; }
        public virtual ICollection<TracePoprcptRtnLine> TracePoprcptRtnLines { get; set; }
        public virtual ICollection<TraceSopdespRcptLine> TraceSopdespRcptLines { get; set; }
        public virtual ICollection<TraceSopinvCredLine> TraceSopinvCredLines { get; set; }
        public virtual ICollection<TraceableAllocationBal> TraceableAllocationBals { get; set; }
        public virtual ICollection<TraceableMovementBal> TraceableMovementBals { get; set; }
    }
}
