using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmforecast
    {
        public long SiconCrmforecastId { get; set; }
        public long SiconCrmforecastTypeId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitValue { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime? Date { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SopinvoiceCreditId { get; set; }
        public long? SopinvoiceCreditLineId { get; set; }
        public long? SiconCrmopportunityId { get; set; }
        public bool ExcludeFromForecast { get; set; }
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
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public long? SiconEmployeeId { get; set; }
        public long? ParentSiconCrmforecastId { get; set; }
    }
}
