using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillDeliveryAddress
    {
        public BlbillDeliveryAddress()
        {
            Blbills = new HashSet<Blbill>();
        }

        public long BlbillDeliveryAddressId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string PostalName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Blbill> Blbills { get; set; }
    }
}
