using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiStockItemCustomerCode
    {
        public long SiStockItemCustomerCodeId { get; set; }
        public long ItemId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public string? CustomerDescription { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public DateTime? SpareDateTime1 { get; set; }
        public DateTime? SpareDateTime2 { get; set; }
        public DateTime? SpareDateTime3 { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public string? CustomerBarcode { get; set; }
    }
}
