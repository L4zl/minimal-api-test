using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcsoporderReturn
    {
        public long SiconIcsoporderReturnId { get; set; }
        public long? SoporderReturnId { get; set; }
        public int SoporderReturnStatus { get; set; }
        public long? LinkedPoporderReturnId { get; set; }
        public string CompanyName { get; set; } = null!;
        public int LinkedPoporderReturnStatus { get; set; }
        public long? OriginalSoporderReturnId { get; set; }
        public string OriginalCompanyName { get; set; } = null!;
        public int OriginalSoporderStatus { get; set; }
        public long? GeneratedPoporderReturnId { get; set; }
        public string GeneratedCompanyName { get; set; } = null!;
        public int GeneratedPoporderReturnStatus { get; set; }
        public long CompanyNumber { get; set; }
        public long OriginalCompanyNumber { get; set; }
        public long GeneratedCompanyNumber { get; set; }
    }
}
