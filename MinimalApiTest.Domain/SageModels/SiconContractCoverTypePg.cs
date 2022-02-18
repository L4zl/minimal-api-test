using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractCoverTypePg
    {
        public long SiconContractCoverTypePgid { get; set; }
        public long SiconContractCoverTypeId { get; set; }
        public long ProductGroupId { get; set; }
        public bool? Included { get; set; }
    }
}
