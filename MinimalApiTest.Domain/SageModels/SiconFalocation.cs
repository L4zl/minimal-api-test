using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFalocation
    {
        public long LocationId { get; set; }
        public string Description { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public bool Removed { get; set; }
        public string Sparetext1 { get; set; } = null!;
        public string Sparetext2 { get; set; } = null!;
        public string Sparetext3 { get; set; } = null!;
        public string Sparetext4 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? BalanceSheetNominal { get; set; }
        public long? ProfitLossNominal { get; set; }
    }
}
