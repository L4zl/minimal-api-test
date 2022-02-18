using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetNomExistsView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public int BsnominalExists { get; set; }
        public int PlnominalExists { get; set; }
    }
}
