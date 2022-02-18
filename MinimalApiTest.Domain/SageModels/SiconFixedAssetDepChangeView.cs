using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetDepChangeView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public decimal? ExpectedLife { get; set; }
        public decimal? AccumulatedDepreciation { get; set; }
        public decimal? DepreciationRate { get; set; }
        public decimal? ExpectedLifeLeft { get; set; }
        public DateTime? CapitalisationDate { get; set; }
        public DateTime? LastDepreciationDate { get; set; }
        public long? DepreciationTypeId { get; set; }
    }
}
