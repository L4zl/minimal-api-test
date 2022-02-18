using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmsuspension
    {
        public long SiconHmsuspensionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? Description { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SiconHmorderId { get; set; }
        public long? SiconHmorderLineId { get; set; }
    }
}
