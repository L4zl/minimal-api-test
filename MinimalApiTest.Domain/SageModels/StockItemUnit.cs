using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemUnit
    {
        public StockItemUnit()
        {
            PopstandardItemLinkArchBuyingPriceUnits = new HashSet<PopstandardItemLinkArch>();
            PopstandardItemLinkArchBuyingUnits = new HashSet<PopstandardItemLinkArch>();
            PopstandardItemLinkBuyingPriceUnits = new HashSet<PopstandardItemLink>();
            PopstandardItemLinkBuyingUnits = new HashSet<PopstandardItemLink>();
            SopstandardItemLinkArchSellingPriceUnits = new HashSet<SopstandardItemLinkArch>();
            SopstandardItemLinkArchSellingUnits = new HashSet<SopstandardItemLinkArch>();
            SopstandardItemLinkSellingPriceUnits = new HashSet<SopstandardItemLink>();
            SopstandardItemLinkSellingUnits = new HashSet<SopstandardItemLink>();
            StockItemDiscounts = new HashSet<StockItemDiscount>();
            StockItemUnitUomtypes = new HashSet<StockItemUnitUomtype>();
            TemitemUnitMappings = new HashSet<TemitemUnitMapping>();
        }

        public long StockItemUnitId { get; set; }
        public long ItemId { get; set; }
        public long UnitId { get; set; }
        public decimal MultipleOfBaseUnit { get; set; }
        public bool UseOwnPrice { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal UnitPrecision { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual Unit Unit { get; set; } = null!;
        public virtual ICollection<PopstandardItemLinkArch> PopstandardItemLinkArchBuyingPriceUnits { get; set; }
        public virtual ICollection<PopstandardItemLinkArch> PopstandardItemLinkArchBuyingUnits { get; set; }
        public virtual ICollection<PopstandardItemLink> PopstandardItemLinkBuyingPriceUnits { get; set; }
        public virtual ICollection<PopstandardItemLink> PopstandardItemLinkBuyingUnits { get; set; }
        public virtual ICollection<SopstandardItemLinkArch> SopstandardItemLinkArchSellingPriceUnits { get; set; }
        public virtual ICollection<SopstandardItemLinkArch> SopstandardItemLinkArchSellingUnits { get; set; }
        public virtual ICollection<SopstandardItemLink> SopstandardItemLinkSellingPriceUnits { get; set; }
        public virtual ICollection<SopstandardItemLink> SopstandardItemLinkSellingUnits { get; set; }
        public virtual ICollection<StockItemDiscount> StockItemDiscounts { get; set; }
        public virtual ICollection<StockItemUnitUomtype> StockItemUnitUomtypes { get; set; }
        public virtual ICollection<TemitemUnitMapping> TemitemUnitMappings { get; set; }
    }
}
