using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WarehouseItem
    {
        public WarehouseItem()
        {
            BinItems = new HashSet<BinItem>();
            PoponOrderBalances = new HashSet<PoponOrderBalance>();
            PoprequisitionFulfilmentLines = new HashSet<PoprequisitionFulfilmentLine>();
            PopstandardItemLinkArches = new HashSet<PopstandardItemLinkArch>();
            PopstandardItemLinks = new HashSet<PopstandardItemLink>();
            PoptoReorderWarehouses = new HashSet<PoptoReorderWarehouse>();
            SoppreReceiptAllocs = new HashSet<SoppreReceiptAlloc>();
            SopstandardItemLinkArches = new HashSet<SopstandardItemLinkArch>();
            SopstandardItemLinks = new HashSet<SopstandardItemLink>();
            StockPreReceiptAllocs = new HashSet<StockPreReceiptAlloc>();
        }

        public long WarehouseItemId { get; set; }
        public long WarehouseId { get; set; }
        public long ItemId { get; set; }
        public decimal ReorderLevel { get; set; }
        public decimal MinimumLevel { get; set; }
        public decimal MaximumLevel { get; set; }
        public DateTime? DateOfLastSale { get; set; }
        public decimal ConfirmedQtyInStock { get; set; }
        public decimal UnconfirmedQtyInStock { get; set; }
        public decimal QuantityAllocatedSop { get; set; }
        public decimal QuantityAllocatedStock { get; set; }
        public decimal QuantityOnPoporder { get; set; }
        public decimal HoldingValueAtBuyPrice { get; set; }
        public DateTime? DateOfLastStockCount { get; set; }
        public decimal PreReceiptAllocationQty { get; set; }
        public decimal QuantityAllocatedBom { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual Warehouse Warehouse { get; set; } = null!;
        public virtual ICollection<BinItem> BinItems { get; set; }
        public virtual ICollection<PoponOrderBalance> PoponOrderBalances { get; set; }
        public virtual ICollection<PoprequisitionFulfilmentLine> PoprequisitionFulfilmentLines { get; set; }
        public virtual ICollection<PopstandardItemLinkArch> PopstandardItemLinkArches { get; set; }
        public virtual ICollection<PopstandardItemLink> PopstandardItemLinks { get; set; }
        public virtual ICollection<PoptoReorderWarehouse> PoptoReorderWarehouses { get; set; }
        public virtual ICollection<SoppreReceiptAlloc> SoppreReceiptAllocs { get; set; }
        public virtual ICollection<SopstandardItemLinkArch> SopstandardItemLinkArches { get; set; }
        public virtual ICollection<SopstandardItemLink> SopstandardItemLinks { get; set; }
        public virtual ICollection<StockPreReceiptAlloc> StockPreReceiptAllocs { get; set; }
    }
}
