using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderRebate
    {
        public long SiconSalesOrderRebateId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SiProductGroupId { get; set; }
        public decimal Percentage { get; set; }
        public string LastUpdatedByUsername { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}
