using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlfactorHouseLocation
    {
        public long PlfactorHouseLocationId { get; set; }
        public long PlfactorHouseId { get; set; }
        public string ContactName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public long SystraderLocationTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlfactorHouse PlfactorHouse { get; set; } = null!;
        public virtual SystraderLocationType SystraderLocationType { get; set; } = null!;
    }
}
