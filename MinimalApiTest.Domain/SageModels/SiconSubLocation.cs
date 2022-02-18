using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSubLocation
    {
        public long SiconSubLocationId { get; set; }
        public string CustDeliveryAddressId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Comment { get; set; }
    }
}
