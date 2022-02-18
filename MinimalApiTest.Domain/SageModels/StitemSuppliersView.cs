using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StitemSuppliersView
    {
        public string? MmsstsCode { get; set; }
        public string MmsstsSupplierAccountName { get; set; } = null!;
        public double? MmsstsQuantityOnOrder { get; set; }
        public string MmsstsName { get; set; } = null!;
        public string MmsstsSupplierAccountNumber { get; set; } = null!;
        public long MmsstsItemId { get; set; }
        public string? MmsstsLeadTime { get; set; }
        public string? MmsstsPreferred { get; set; }
    }
}
