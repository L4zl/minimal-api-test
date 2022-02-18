using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkcountSheetItemView
    {
        public long StocktakeId { get; set; }
        public long BinItemId { get; set; }
        public long ItemId { get; set; }
        public bool ActualQuantityEntered { get; set; }
        public long TraceableTypeId { get; set; }
    }
}
