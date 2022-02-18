using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmlastSalesOrderDateView
    {
        public long SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public DateTime? LastSalesOrderDate { get; set; }
    }
}
