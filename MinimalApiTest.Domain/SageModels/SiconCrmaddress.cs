using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmaddress
    {
        public long SiconCrmaddressId { get; set; }
        public string PostalName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public long? CustDeliveryAddressId { get; set; }
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
        public long? SlcustomerLocationId { get; set; }
        public long? PlsupplierLocationId { get; set; }
    }
}
