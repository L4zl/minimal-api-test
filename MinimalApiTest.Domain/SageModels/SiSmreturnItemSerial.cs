using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmreturnItemSerial
    {
        public long SiSmreturnItemSerialId { get; set; }
        public long? SiSmreturnItemId { get; set; }
        public string? IdentificationNo { get; set; }
        public decimal? Quantity { get; set; }
    }
}
