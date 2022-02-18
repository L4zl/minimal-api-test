using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderLineView
    {
        public long SiconSalesOrderId { get; set; }
        public decimal? LineTotal { get; set; }
    }
}
