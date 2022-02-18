using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderJclabResource
    {
        public long SiWorksOrderJclabResourceId { get; set; }
        public long? ResourceId { get; set; }
        public long? JobHeaderId { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
