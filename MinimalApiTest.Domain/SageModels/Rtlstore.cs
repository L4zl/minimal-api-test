using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtlstore
    {
        public long StoreId { get; set; }
        public long HierNodeId { get; set; }
        public string StoreName { get; set; } = null!;
        public string? StoreShortName { get; set; }
        public string? Description { get; set; }
        public long? StoreTypeId { get; set; }
        public long? StoreSize { get; set; }
        public long? StoreStatusId { get; set; }
        public long? OperationalStatusId { get; set; }
        public long? LocationTypeId { get; set; }
        public string? PostalName { get; set; }
        public string? PostalCode { get; set; }
        public string? Contact { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public long? ReplMethodId { get; set; }
        public long? ReplSourceId { get; set; }
        public bool AutoRepl { get; set; }
        public long? DelRouteId { get; set; }
        public string? NominalDetail1 { get; set; }
        public string? NominalDetail2 { get; set; }
        public string? NominalDetail3 { get; set; }
        public string? NominalDetail4 { get; set; }
        public string? Memo { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? Country { get; set; }
        public string? Address5 { get; set; }
        public string? Address6 { get; set; }
        public string? TelephoneAreaCode1 { get; set; }
        public string? TelephoneCountryCode1 { get; set; }
        public string? TelephoneSubscriberNumber1 { get; set; }
        public string? TelephoneAreaCode2 { get; set; }
        public string? TelephoneCountryCode2 { get; set; }
        public string? TelephoneSubscriberNumber2 { get; set; }
        public string? TelephoneAreaCode3 { get; set; }
        public string? TelephoneCountryCode3 { get; set; }
        public string? TelephoneSubscriberNumber3 { get; set; }
        public string? FaxAreaCode { get; set; }
        public string? FaxCountryCode { get; set; }
        public string? FaxSubscriberNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public long? TaxCountry { get; set; }
        public long? Salutation { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
