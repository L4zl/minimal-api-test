using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopordersCurrentValuesView
    {
        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public decimal ValueOfCurrentOrdersInPop { get; set; }
        public string Symbol { get; set; } = null!;
        public decimal SumGross { get; set; }
    }
}
