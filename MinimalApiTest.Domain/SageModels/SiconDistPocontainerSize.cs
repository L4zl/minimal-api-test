using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPocontainerSize
    {
        public long SiconDistPocontainerSizeId { get; set; }
        public string? ContainerSize { get; set; }
        public decimal? MaxVolume { get; set; }
        public decimal? MaxPayload { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
