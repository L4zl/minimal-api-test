using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDiview
    {
        public decimal? Amount { get; set; }
        public string? Month { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public string AccountName { get; set; } = null!;
    }
}
