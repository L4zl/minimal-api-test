using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkstockTakeItemView
    {
        public DateTime? BidateOfLastStockCount { get; set; }
        public DateTime? WidateOfLastStockCount { get; set; }
        public long StocktakeId { get; set; }
        public bool ActualQuantityEntered { get; set; }
        public long TraceableTypeId { get; set; }
    }
}
