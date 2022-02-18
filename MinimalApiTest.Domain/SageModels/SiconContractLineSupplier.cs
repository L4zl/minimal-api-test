using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractLineSupplier
    {
        public long SiconContractLineSupplierId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? UnitCost { get; set; }
        public string? Description { get; set; }
        public string? PurchaseOrderNumber { get; set; }
        public string? SecondReference { get; set; }
        public long SiconContractLineId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public bool? Allocated { get; set; }
    }
}
