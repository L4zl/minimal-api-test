using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockMatrixAttrOption
    {
        public long SiDistStockMatrixAttrOptionId { get; set; }
        public long? SiDistStockMatrixAttributeId { get; set; }
        public string? Option { get; set; }
        public string? OptionShortName { get; set; }
        public long? Sequence { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
