using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiBespokeType
    {
        public long SiBespokeTypeId { get; set; }
        public string TypeKey { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public string DeletedByUserId { get; set; } = null!;
        public DateTime? DeletedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
