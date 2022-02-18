using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierLocation
    {
        public PlsupplierLocation()
        {
            PlsupplierContacts = new HashSet<PlsupplierContact>();
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
        }

        public long PlsupplierLocationId { get; set; }
        public long PlsupplierAccountId { get; set; }
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
        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
        public virtual SystraderLocationType SystraderLocationType { get; set; } = null!;
        public virtual ICollection<PlsupplierContact> PlsupplierContacts { get; set; }
        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
    }
}
