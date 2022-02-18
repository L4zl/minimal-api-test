using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSolineApplication
    {
        public long SiconSolineApplicationId { get; set; }
        public long SiconConstructionApplicationId { get; set; }
        public long SiconSalesOrderLineId { get; set; }
        public decimal? QuantityAppliedFor { get; set; }
    }
}
