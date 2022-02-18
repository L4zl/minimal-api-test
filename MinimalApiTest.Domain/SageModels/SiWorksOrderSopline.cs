using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSopline
    {
        public long SiWorksOrderSoplineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? WorksOrderComments { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
