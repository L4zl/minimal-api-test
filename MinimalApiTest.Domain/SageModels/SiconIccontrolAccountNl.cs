using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIccontrolAccountNl
    {
        public long SiconIccontrolAccountNlid { get; set; }
        public long SiconIccontrolAccountId { get; set; }
        public long SyscurrencyId { get; set; }
        public string Isocode { get; set; } = null!;
        public long NlnominalAccountId { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
