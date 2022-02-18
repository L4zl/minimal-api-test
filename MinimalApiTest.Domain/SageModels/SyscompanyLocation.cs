using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscompanyLocation
    {
        public long SyscompanyLocationId { get; set; }
        public long SyscompanyId { get; set; }
        public long SyscountryCodeId { get; set; }
        public long SyscompanyLocationTypeId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? PostCode { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? WebAddress { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscompany Syscompany { get; set; } = null!;
        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
    }
}
