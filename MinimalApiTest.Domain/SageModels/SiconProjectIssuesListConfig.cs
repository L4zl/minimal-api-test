using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectIssuesListConfig
    {
        public long SiconProjectIssuesListConfigId { get; set; }
        public string? ConfigType { get; set; }
        public string? Code { get; set; }
        public string? BackColour { get; set; }
    }
}
