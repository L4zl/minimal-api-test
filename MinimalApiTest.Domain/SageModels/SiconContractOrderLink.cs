using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractOrderLink
    {
        public long SiconContractOrderLinkId { get; set; }
        public long SoporderReturnId { get; set; }
        public long? SiconContractId { get; set; }
        public string? DocumentNo { get; set; }
        public long? DocumentTypeId { get; set; }
    }
}
