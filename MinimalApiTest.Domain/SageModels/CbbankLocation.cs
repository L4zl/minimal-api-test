using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankLocation
    {
        public long CbbankLocationId { get; set; }
        public long CbaccountId { get; set; }
        public long CbaccountLocationTypeId { get; set; }
        public string ContactName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual CbaccountLocationType CbaccountLocationType { get; set; } = null!;
    }
}
