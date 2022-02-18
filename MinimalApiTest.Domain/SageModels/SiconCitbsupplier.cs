using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCitbsupplier
    {
        public long SiconCitbsupplierId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? Citb { get; set; }
        public byte Citbdeduct { get; set; }
    }
}
