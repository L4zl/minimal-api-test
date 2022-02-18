using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractDiscountType
    {
        public long SiconContractDiscountTypeId { get; set; }
        public string? Description { get; set; }
        public int Ordinal { get; set; }
    }
}
