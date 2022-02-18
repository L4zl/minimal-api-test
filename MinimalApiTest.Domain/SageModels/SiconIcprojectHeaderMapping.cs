using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcprojectHeaderMapping
    {
        public long SiconIcprojectHeaderMappingId { get; set; }
        public string RevenueHeader { get; set; } = null!;
        public long? SiconIccontrolAccountId { get; set; }
        public long CompanyNumber { get; set; }
        public string MappedCostHeader { get; set; } = null!;
    }
}
