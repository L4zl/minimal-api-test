using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractValueProductView
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long ItemId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalNetAfterDiscount { get; set; }
    }
}
