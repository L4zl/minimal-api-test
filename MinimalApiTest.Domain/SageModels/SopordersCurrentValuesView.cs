using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopordersCurrentValuesView
    {
        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public decimal ValueOfCurrentOrdersInSop { get; set; }
        public string Symbol { get; set; } = null!;
        public decimal SumGross { get; set; }
    }
}
