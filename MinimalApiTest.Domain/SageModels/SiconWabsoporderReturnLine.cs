using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabsoporderReturnLine
    {
        public long SiconWabsoporderReturnLineId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public decimal PickedQuantity { get; set; }
        public decimal PackedQuantity { get; set; }
    }
}
