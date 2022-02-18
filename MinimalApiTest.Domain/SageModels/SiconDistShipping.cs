using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistShipping
    {
        public long SiconDistShippingId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? Type { get; set; }
        public string? Carrier { get; set; }
        public string? Service { get; set; }
        public string? VehicleType { get; set; }
        public decimal? TotalWeight { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string? SpecialInstructions { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
