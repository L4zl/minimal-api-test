using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            ProdGroupNominalCodes = new HashSet<ProdGroupNominalCode>();
            ProdGroupSearchCats = new HashSet<ProdGroupSearchCat>();
            ProductGroupBatchAttributes = new HashSet<ProductGroupBatchAttribute>();
            ProductGroupDiscounts = new HashSet<ProductGroupDiscount>();
            ProductGroupUnits = new HashSet<ProductGroupUnit>();
            StockItems = new HashSet<StockItem>();
        }

        public long ProductGroupId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool UseDescriptionOnDocs { get; set; }
        public long StockItemTypeId { get; set; }
        public long CostingMethodId { get; set; }
        public short StocktakeCyclePeriod { get; set; }
        public bool? DoItemsMaintainHistory { get; set; }
        public bool DoItemsUseMarkup { get; set; }
        public decimal MarkupPercent { get; set; }
        public bool CanItemLevelsGoNegative { get; set; }
        public bool DoItemsUseUnits { get; set; }
        public bool SellQuantsUseMultUnits { get; set; }
        public bool BuyQuantsUseMultUnits { get; set; }
        public bool SellPricesUseMultUnits { get; set; }
        public bool BuyPricesUseMultUnits { get; set; }
        public bool ThisIsTheSopproductGroup { get; set; }
        public long TraceableTypeId { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public DateTime? LastArchivedUpTo { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime? LastTraceArchivedUpTo { get; set; }
        public bool UseLandedCosts { get; set; }
        public long LandedCostsTypeId { get; set; }
        public decimal LandedCostsValue { get; set; }
        public long StklabelPrintingOptionTypeId { get; set; }
        public bool UsesRcv { get; set; }
        public bool CanOverAllocateNegativeStock { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CostingMethod CostingMethod { get; set; } = null!;
        public virtual LandedCostsType LandedCostsType { get; set; } = null!;
        public virtual StklabelPrintingOptionType StklabelPrintingOptionType { get; set; } = null!;
        public virtual StockItemType StockItemType { get; set; } = null!;
        public virtual TraceableType TraceableType { get; set; } = null!;
        public virtual ICollection<ProdGroupNominalCode> ProdGroupNominalCodes { get; set; }
        public virtual ICollection<ProdGroupSearchCat> ProdGroupSearchCats { get; set; }
        public virtual ICollection<ProductGroupBatchAttribute> ProductGroupBatchAttributes { get; set; }
        public virtual ICollection<ProductGroupDiscount> ProductGroupDiscounts { get; set; }
        public virtual ICollection<ProductGroupUnit> ProductGroupUnits { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
