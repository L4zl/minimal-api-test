using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractLineRenewalDiscount
    {
        public long SiconContractLineDiscountId { get; set; }
        public long? SiconContractDiscountTypeId { get; set; }
        public decimal? Percent { get; set; }
        public decimal? Value { get; set; }
        public int Ordinal { get; set; }
        public bool? DiscountPercentSpecified { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? SiconContractLineId { get; set; }
    }
}
