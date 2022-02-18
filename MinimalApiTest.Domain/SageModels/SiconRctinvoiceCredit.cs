using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRctinvoiceCredit
    {
        public long SiconRctinvoiceCreditId { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? Urn { get; set; }
        public decimal? LabourPc { get; set; }
        public decimal? LabourValue { get; set; }
        public decimal? MaterialsPc { get; set; }
        public decimal? MaterialsValue { get; set; }
        public decimal? OtherPc { get; set; }
        public decimal? OtherValue { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
