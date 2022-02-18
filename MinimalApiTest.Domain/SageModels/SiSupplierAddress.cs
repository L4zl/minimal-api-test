using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSupplierAddress
    {
        public long SiSupplierAddressId { get; set; }
        public long? SupplierId { get; set; }
        public string? Description { get; set; }
        public string? PostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? PostCode { get; set; }
        public long? CountryCodeId { get; set; }
        public string? Country { get; set; }
        public string? Contact { get; set; }
        public string? TelephoneNo { get; set; }
        public string? FaxNo { get; set; }
        public string? EmailAddress { get; set; }
    }
}
