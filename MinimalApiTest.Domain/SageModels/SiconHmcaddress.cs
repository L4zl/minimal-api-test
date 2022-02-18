using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcaddress
    {
        public long SiconHmcaddressId { get; set; }
        public long ParentRecordId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string AddressLine5 { get; set; } = null!;
        public string AddressLine6 { get; set; } = null!;
        public string AddressLine7 { get; set; } = null!;
        public string AddressLine8 { get; set; } = null!;
        public string AddressLine9 { get; set; } = null!;
        public string AddressLine10 { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
