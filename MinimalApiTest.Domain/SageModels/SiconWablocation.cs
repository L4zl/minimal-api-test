using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWablocation
    {
        public long SiconWablocationId { get; set; }
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public long Sequence { get; set; }
        public bool? DespatchBin { get; set; }
        public long? DefaultPriority { get; set; }
        public long? SiconWabzoneId { get; set; }
        public long? WarehouseId { get; set; }
    }
}
