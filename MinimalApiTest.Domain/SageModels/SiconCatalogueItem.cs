using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCatalogueItem
    {
        public long SiconCatalogueItemId { get; set; }
        public long? SupplierId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public string ProductGroup { get; set; } = null!;
        public string BuyingUnitDescription { get; set; } = null!;
        public decimal? BuyingPrice { get; set; }
        public string TaxCode { get; set; } = null!;
        public long? NlnominalAccountId { get; set; }
        public string JobHeader { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
