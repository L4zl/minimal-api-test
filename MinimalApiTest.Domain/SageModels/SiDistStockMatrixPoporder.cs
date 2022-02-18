using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockMatrixPoporder
    {
        public long SiDistStockMatrixPoporderId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? SiDistStockItemGroupId { get; set; }
        public long? ItemId { get; set; }
        public decimal LineQuantity { get; set; }
        public int Yindex { get; set; }
        public int Xindex { get; set; }
        public string Yattribute { get; set; } = null!;
    }
}
