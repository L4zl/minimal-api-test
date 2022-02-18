using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerLocation
    {
        public SlcustomerLocation()
        {
            SlcustomerContacts = new HashSet<SlcustomerContact>();
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
        }

        public long SlcustomerLocationId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SyscountryCodeId { get; set; }
        public long SystraderLocationTypeId { get; set; }
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
        public long AddressCountryId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode AddressCountry { get; set; } = null!;
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
        public virtual SystraderLocationType SystraderLocationType { get; set; } = null!;
        public virtual ICollection<SlcustomerContact> SlcustomerContacts { get; set; }
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
    }
}
