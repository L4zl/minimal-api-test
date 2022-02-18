using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKit
    {
        public SiconKit()
        {
            SiconKitLines = new HashSet<SiconKitLine>();
        }

        public long SiconKitId { get; set; }
        public string Reference { get; set; } = null!;
        public long ItemId { get; set; }
        public decimal LabourQuantity { get; set; }
        public decimal MachineryQuantity { get; set; }
        public decimal? FinishedItemQuantity { get; set; }
        public decimal TotalCost { get; set; }
        public long? SiconKitTemplateId { get; set; }
        public string BinName { get; set; } = null!;
        public string InternalArea { get; set; } = null!;
        public decimal QuantityReturned { get; set; }
        public bool FullyReturned { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
        public long? BinItemId { get; set; }
        public string? Status { get; set; }
        public long? CustomerId { get; set; }
        public decimal? SalePrice { get; set; }
        public string? ItemSerialNumber { get; set; }
        public string? KitType { get; set; }
        public DateTime? DateRequired { get; set; }
        public long? ParentKitLineId { get; set; }
        public int? KitLevel { get; set; }
        public long WarehouseId { get; set; }
        public decimal QuantityBuilt { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual SiconKitTemplate? SiconKitTemplate { get; set; }
        public virtual ICollection<SiconKitLine> SiconKitLines { get; set; }
    }
}
