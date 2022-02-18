using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustomerPriceBandVw
    {
        public long? SiconCustomerPriceBandId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PriceBandId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? ActiveFromDate { get; set; }
        public DateTime? ActiveToDate { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool? ThisIsTheStandardBand { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? SiconIsActive { get; set; }
    }
}
