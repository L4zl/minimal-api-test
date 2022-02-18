using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabtraceLabel
    {
        public long SiconWabtraceLabelId { get; set; }
        public int TypeId { get; set; }
        public long ForeignId { get; set; }
        public string? IdentificationNo { get; set; }
        public decimal? BatchQuantity { get; set; }
        public int TraceableTypeId { get; set; }
        public string SessionGuid { get; set; } = null!;
        public DateTime? UseByDate { get; set; }
        public DateTime? SellByDate { get; set; }
    }
}
