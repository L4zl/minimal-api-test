using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiCustDelivAddPriceband
    {
        public long SiCustDelivAddPricebandId { get; set; }
        public long? CustomerAddressId { get; set; }
        public long? PriceBandId { get; set; }
        public long? CustomerDiscountGroupId { get; set; }
        public int? ItemTypePriceOverrideId { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
