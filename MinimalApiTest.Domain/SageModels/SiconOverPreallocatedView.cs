using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconOverPreallocatedView
    {
        public long? SalesOrderLineId { get; set; }
        public decimal? PreallocatedQuantity { get; set; }
        public decimal? RemainingLineQuantity { get; set; }
    }
}
