using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopstandardItemLinkArch
    {
        public long SopstandardItemLinkId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long ItemId { get; set; }
        public long? WarehouseItemId { get; set; }
        public long SellingUnitId { get; set; }
        public long SellingPriceUnitId { get; set; }
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
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual StockItemUnit SellingPriceUnit { get; set; } = null!;
        public virtual StockItemUnit SellingUnit { get; set; } = null!;
        public virtual SoporderReturnLineArch SoporderReturnLine { get; set; } = null!;
        public virtual WarehouseItem? WarehouseItem { get; set; }
    }
}
