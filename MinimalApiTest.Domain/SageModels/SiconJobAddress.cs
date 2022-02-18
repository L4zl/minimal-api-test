using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobAddress
    {
        public long SiconJobAddressId { get; set; }
        public long? SiJcJobId { get; set; }
        public bool? IsDefault { get; set; }
        public string? AddressPostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressContact { get; set; }
        public string? AddressTelephone { get; set; }
        public string? AddressFax { get; set; }
        public string? AddressEmail { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public string? SiteNotes { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
    }
}
