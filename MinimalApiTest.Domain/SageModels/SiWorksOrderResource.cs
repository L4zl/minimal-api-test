using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderResource
    {
        public long SiWorksOrderResourceId { get; set; }
        public long? ResourceId { get; set; }
        public string? Reference { get; set; }
        public decimal? SalesRate { get; set; }
        public string? LastUpdatedUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
