using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MovementBalance
    {
        public MovementBalance()
        {
            SopdespatchReceiptLineShortfalls = new HashSet<SopdespatchReceiptLineShortfall>();
            StockHistoryShortfalls = new HashSet<StockHistoryShortfall>();
            TraceableMovementBals = new HashSet<TraceableMovementBal>();
        }

        public long MovementId { get; set; }
        public long BinItemId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public long MovementBalanceTypeId { get; set; }
        public long SourceAreaTypeId { get; set; }
        public string SourceAreaReference { get; set; } = null!;
        public string SourceAreaName { get; set; } = null!;
        public decimal OpeningStockLevel { get; set; }
        public decimal StockLevelIssued { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime? MovementDate { get; set; }
        public string MovementReference { get; set; } = null!;
        public string? SecondReference { get; set; }
        public long PostingUrn { get; set; }
        public short PostingSource { get; set; }
        public int PostingUser { get; set; }
        public long EntrySourceId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal UnitLandedCosts { get; set; }
        public decimal QuantityReserved { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BinItem BinItem { get; set; } = null!;
        public virtual EntrySource EntrySource { get; set; } = null!;
        public virtual MovementBalanceType MovementBalanceType { get; set; } = null!;
        public virtual SourceAreaType SourceAreaType { get; set; } = null!;
        public virtual ICollection<SopdespatchReceiptLineShortfall> SopdespatchReceiptLineShortfalls { get; set; }
        public virtual ICollection<StockHistoryShortfall> StockHistoryShortfalls { get; set; }
        public virtual ICollection<TraceableMovementBal> TraceableMovementBals { get; set; }
    }
}
