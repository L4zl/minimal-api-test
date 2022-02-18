using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlpricingDefaultSupplier
    {
        public long PricingDefSuppsId { get; set; }
        public long PrdHierNodeId { get; set; }
        public string SupplierCode { get; set; } = null!;
        public bool IsPreferred { get; set; }
        public decimal? LastBuyingPrice { get; set; }
        public decimal? ListPrice { get; set; }
        public DateTime? DateListPriceChanged { get; set; }
        public DateTime? ListPriceExpiryDate { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public long DefaultPricingSourceTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
