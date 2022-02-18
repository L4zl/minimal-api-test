using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmtotalUnallocatedSprview
    {
        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public int? Payments { get; set; }
        public int? Receipts { get; set; }
    }
}
