using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PayPortGroupDiscVw
    {
        public long? CustomerDiscountGroupId { get; set; }
        public long? PriceBandId { get; set; }
        public long ProductGroupDiscountId { get; set; }
        public string DiscGrpName { get; set; } = null!;
        public string PriceBandName { get; set; } = null!;
        public string Category { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public decimal QuantityMoreThan { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public string ItemCode { get; set; } = null!;
    }
}
