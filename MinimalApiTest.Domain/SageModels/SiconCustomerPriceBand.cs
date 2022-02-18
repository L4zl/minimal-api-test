using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustomerPriceBand
    {
        public long SiconCustomerPriceBandId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PriceBandId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActiveFromDate { get; set; }
        public DateTime? ActiveToDate { get; set; }
        public string DeletedByUserId { get; set; } = null!;
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
