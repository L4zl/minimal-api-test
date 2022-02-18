using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopallocationLine
    {
        public SopallocationLine()
        {
            SoppreReceiptAllocs = new HashSet<SoppreReceiptAlloc>();
        }

        public long SopallocationLineId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long AllocationId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime AllocatedDate { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public decimal DespatchedQuantity { get; set; }
        public long PickingListPrintStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitAllocatedQuantity { get; set; }
        public decimal StockUnitDespatchedQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AllocationBalance Allocation { get; set; } = null!;
        public virtual DocumentPrintStatus PickingListPrintStatus { get; set; } = null!;
        public virtual SoporderReturnLine SoporderReturnLine { get; set; } = null!;
        public virtual ICollection<SoppreReceiptAlloc> SoppreReceiptAllocs { get; set; }
    }
}
