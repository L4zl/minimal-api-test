using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcontactInfo
    {
        public long SiconCrmcontactInfoId { get; set; }
        public long SiconCrmcontactInfoTypeId { get; set; }
        public string TelephoneNumber { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
        public string FaxNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string WebsiteUrl { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public string? SpareText6 { get; set; }
        public string? SpareText7 { get; set; }
        public string? SpareText8 { get; set; }
        public string? SpareText9 { get; set; }
        public string? SpareText10 { get; set; }
        public bool? SpareBit1 { get; set; }
        public bool? SpareBit2 { get; set; }
        public bool? SpareBit3 { get; set; }
        public bool? SpareBit4 { get; set; }
        public bool? SpareBit5 { get; set; }
        public bool? SpareBit6 { get; set; }
        public bool? SpareBit7 { get; set; }
        public bool? SpareBit8 { get; set; }
        public bool? SpareBit9 { get; set; }
        public bool? SpareBit10 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public DateTime? SpareDate4 { get; set; }
        public DateTime? SpareDate5 { get; set; }
        public DateTime? SpareDate6 { get; set; }
        public DateTime? SpareDate7 { get; set; }
        public DateTime? SpareDate8 { get; set; }
        public DateTime? SpareDate9 { get; set; }
        public DateTime? SpareDate10 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public decimal? SpareNumber6 { get; set; }
        public decimal? SpareNumber7 { get; set; }
        public decimal? SpareNumber8 { get; set; }
        public decimal? SpareNumber9 { get; set; }
        public decimal? SpareNumber10 { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierContactId { get; set; }
        public long? SlcustomerContactId { get; set; }
        public string TelephoneNumberCountryCode { get; set; } = null!;
        public string TelephoneNumberAreaCode { get; set; } = null!;
        public string TelephoneNumberSubscriber { get; set; } = null!;
        public string FaxNumberCountryCode { get; set; } = null!;
        public string FaxNumberAreaCode { get; set; } = null!;
        public string FaxNumberSubscriber { get; set; } = null!;
        public string MobileNumberCountryCode { get; set; } = null!;
        public string MobileNumberAreaCode { get; set; } = null!;
        public string MobileNumberSubscriber { get; set; } = null!;
    }
}
