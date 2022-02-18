using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcpoporderReturn
    {
        public long SiconIcpoporderReturnId { get; set; }
        public long? PoporderReturnId { get; set; }
        public int PoporderReturnStatus { get; set; }
        public long? LinkedSoporderReturnId { get; set; }
        public string CompanyName { get; set; } = null!;
        public int LinkedSoporderReturnStatus { get; set; }
        public long? OriginalSoporderReturnId { get; set; }
        public string OriginalCompanyName { get; set; } = null!;
        public int OriginalSoporderReturnStatus { get; set; }
        public long? GeneratedPoporderReturnId { get; set; }
        public string GeneratedCompanyName { get; set; } = null!;
        public int GeneratedPoporderReturnStatus { get; set; }
        public long CompanyNumber { get; set; }
        public long OriginalCompanyNumber { get; set; }
        public long GeneratedCompanyNumber { get; set; }
    }
}
