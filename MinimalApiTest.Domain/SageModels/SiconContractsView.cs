using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractsView
    {
        public long SiconContractId { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? ContractNumber { get; set; }
        public decimal? NetBeforeDiscount { get; set; }
        public decimal? TotalCostValue { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalNetAfterDiscount { get; set; }
        public string SpareText3 { get; set; } = null!;
        public string SpareText4 { get; set; } = null!;
        public string SpareText5 { get; set; } = null!;
        public string SpareText6 { get; set; } = null!;
        public string SpareText7 { get; set; } = null!;
        public decimal SpareNumber3 { get; set; }
        public decimal SpareNumber4 { get; set; }
        public decimal SpareNumber5 { get; set; }
        public decimal SpareNumber6 { get; set; }
        public decimal SpareNumber7 { get; set; }
        public DateTime? SpareDateTime3 { get; set; }
        public DateTime? SpareDateTime4 { get; set; }
        public DateTime? SpareDateTime5 { get; set; }
        public DateTime? SpareDateTime6 { get; set; }
        public DateTime? SpareDateTime7 { get; set; }
    }
}
