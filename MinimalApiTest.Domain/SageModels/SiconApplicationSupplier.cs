using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconApplicationSupplier
    {
        public long SiconApplicationSupplierId { get; set; }
        public bool IsSubcontractor { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public bool UseApplications { get; set; }
    }
}
