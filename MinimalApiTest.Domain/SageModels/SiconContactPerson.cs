using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContactPerson
    {
        public long SiconContactPersonId { get; set; }
        public long SiconContactPersonTypeId { get; set; }
        public long? SiconContactTerritoryId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SlcustomerContactId { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SiconSubLocationId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? PlsupplierContactId { get; set; }
        public string ExternalId { get; set; } = null!;
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? Department { get; set; }
        public string? BusinessTel { get; set; }
        public string? MobileTel { get; set; }
        public string? Email { get; set; }
        public bool? Deleted { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }
        public string? County { get; set; }
        public string? CompanyName { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
