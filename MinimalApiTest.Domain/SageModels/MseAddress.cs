using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseAddress
    {
        public MseAddress()
        {
            MseContactAddresses = new HashSet<MseContactAddress>();
        }

        public long MseAddressId { get; set; }
        public long? SyscountryCodeId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MseContactAddress> MseContactAddresses { get; set; }
    }
}
