using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitLine
    {
        public SiconKitLine()
        {
            SiconKitIssueLines = new HashSet<SiconKitIssueLine>();
        }

        public long SiconKitLineId { get; set; }
        public long ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public string InternalAreaName { get; set; } = null!;
        public decimal TotalCost { get; set; }
        public long SiconKitId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
        public decimal? OriginalDesignQuantity { get; set; }
        public string? Status { get; set; }
        public decimal? LineSalePrice { get; set; }
        public string? ItemSerialNumber { get; set; }
        public long? ChildKitId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? AllocatedQuantity { get; set; }
        public long? BinItemId { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual SiconKit SiconKit { get; set; } = null!;
        public virtual ICollection<SiconKitIssueLine> SiconKitIssueLines { get; set; }
    }
}
