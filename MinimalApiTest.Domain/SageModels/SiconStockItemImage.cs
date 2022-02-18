using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockItemImage
    {
        public long SiconStockItemImageId { get; set; }
        public long? SiconStockItemImageTypeId { get; set; }
        public long StockItemId { get; set; }
        public string StockItemCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsDefaultImage { get; set; }
        public string OriginalFileName { get; set; } = null!;
        public string ReferenceFolder { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string ImageFileName { get; set; } = null!;
        public string ThumbnailFileName { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
