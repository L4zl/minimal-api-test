using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNcrcase
    {
        public long SiconNcrcaseId { get; set; }
        public long SiSmcaseId { get; set; }
        public bool CustomerNcrenabled { get; set; }
        public bool SupplierNcrenabled { get; set; }
        public long? SoporderReturn { get; set; }
    }
}
