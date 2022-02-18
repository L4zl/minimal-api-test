using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDepotAddress
    {
        public long SiconDepotAddressId { get; set; }
        public long? CustomerId { get; set; }
        public string? Description { get; set; }
        public string? PostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? PostCode { get; set; }
        public long? AddressCountryCodeId { get; set; }
        public string? Country { get; set; }
        public string? Contact { get; set; }
        public string? TelephoneNo { get; set; }
        public string? FaxNo { get; set; }
        public string? EmailAddress { get; set; }
        public string? Caddress1 { get; set; }
        public string? Caddress2 { get; set; }
        public string? Caddress3 { get; set; }
        public string? Caddress4 { get; set; }
        public string? Caddress5 { get; set; }
        public string? Caddress6 { get; set; }
        public string? Caddress7 { get; set; }
        public string? Caddress8 { get; set; }
        public string? Caddress9 { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
