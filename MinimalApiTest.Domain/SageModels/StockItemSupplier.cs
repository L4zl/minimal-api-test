using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemSupplier
    {
        public long StockItemSupplierId { get; set; }
        public long ItemId { get; set; }
        public long SupplierId { get; set; }
        public string SupplierStockCode { get; set; } = null!;
        public short LeadTime { get; set; }
        public long? LeadTimeUnitId { get; set; }
        public decimal UsualOrderQuantity { get; set; }
        public decimal MinimumOrderQuantity { get; set; }
        public bool Preferred { get; set; }
        public DateTime? DateLastOrder { get; set; }
        public decimal LastBuyingPrice { get; set; }
        public decimal LastOrderQuantity { get; set; }
        public decimal OrderQuantityYtd { get; set; }
        public decimal OrderValueYtd { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public decimal LastBaseBuyingPrice { get; set; }
        public decimal CataloguePrice { get; set; }
        public DateTime? CataloguePriceDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal ListPrice { get; set; }
        public decimal ListBasePrice { get; set; }
        public DateTime? DateListPriceChanged { get; set; }
        public DateTime? ListPriceExpiryDate { get; set; }
        public long DefaultPricingSourceTypeId { get; set; }
        public long LandedCostsTypeId { get; set; }
        public decimal LandedCostsValue { get; set; }
        public decimal ReorderMultipleQty { get; set; }
        public long? CountryOfOriginId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode? CountryOfOrigin { get; set; }
        public virtual DefaultPricingSourceType DefaultPricingSourceType { get; set; } = null!;
        public virtual StockItem Item { get; set; } = null!;
        public virtual LandedCostsType LandedCostsType { get; set; } = null!;
        public virtual TimeUnit? LeadTimeUnit { get; set; }
        public virtual PlsupplierAccount Supplier { get; set; } = null!;
    }
}
