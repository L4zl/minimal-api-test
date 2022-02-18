using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderBomrecord
    {
        public long SiWorksOrderBomrecordId { get; set; }
        public long? BomrecordId { get; set; }
        public decimal? Yield { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
