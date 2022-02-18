using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopstandardItemLink
    {
        public long PopstandardItemLinkId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public long BuyingUnitId { get; set; }
        public long BuyingPriceUnitId { get; set; }
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

        public virtual StockItemUnit BuyingPriceUnit { get; set; } = null!;
        public virtual StockItemUnit BuyingUnit { get; set; } = null!;
        public virtual StockItem Item { get; set; } = null!;
        public virtual PoporderReturnLine PoporderReturnLine { get; set; } = null!;
        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
    }
}
