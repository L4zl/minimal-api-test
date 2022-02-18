using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopdocDelAddress
    {
        public long SopdocDelAddressId { get; set; }
        public long SoporderReturnId { get; set; }
        public string Description { get; set; } = null!;
        public string PostalName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string TaxNo { get; set; } = null!;
        public long TaxCodeId { get; set; }
        public long? CountryCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode? CountryCode { get; set; }
        public virtual SoporderReturn SoporderReturn { get; set; } = null!;
        public virtual SystaxRate TaxCode { get; set; } = null!;
    }
}
