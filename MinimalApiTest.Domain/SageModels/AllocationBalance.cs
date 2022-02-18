using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AllocationBalance
    {
        public AllocationBalance()
        {
            StockPreReceiptAllocs = new HashSet<StockPreReceiptAlloc>();
            TraceableAllocationBals = new HashSet<TraceableAllocationBal>();
        }

        public long AllocationId { get; set; }
        public long? BinItemId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public long SourceAreaTypeId { get; set; }
        public string RecipientReference { get; set; } = null!;
        public string RecipientName { get; set; } = null!;
        public decimal AllocatedQuantity { get; set; }
        public DateTime AllocationDate { get; set; }
        public string Reference { get; set; } = null!;
        public string SecondRef { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public string OrderPriority { get; set; } = null!;
        public long? EntrySourceId { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BinItem? BinItem { get; set; }
        public virtual EntrySource? EntrySource { get; set; }
        public virtual SourceAreaType SourceAreaType { get; set; } = null!;
        public virtual SopallocationLine SopallocationLine { get; set; } = null!;
        public virtual ICollection<StockPreReceiptAlloc> StockPreReceiptAllocs { get; set; }
        public virtual ICollection<TraceableAllocationBal> TraceableAllocationBals { get; set; }
    }
}
