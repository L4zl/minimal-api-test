using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetsNominalsExt
    {
        public long SiconFixedAssetsNominalsExtId { get; set; }
        public long SiconFixedAssetId { get; set; }
        public long NominalAccountId { get; set; }
        public int? NominalType { get; set; }
        public decimal? Percentage { get; set; }
    }
}
