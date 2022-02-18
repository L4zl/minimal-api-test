using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcVariation
    {
        public long SiJcVariationId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public string? Ponumber { get; set; }
        public decimal? Price { get; set; }
        public string? VariationStatus { get; set; }
        public decimal? PercentageComplete { get; set; }
    }
}
