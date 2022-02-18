using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaiinvoiceField
    {
        public long SiconDmsaiinvoiceFieldId { get; set; }
        public long? SiconDmsaiinvoiceId { get; set; }
        public long? SiconDmsaiinvoiceLineId { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Description { get; set; } = null!;
        public short PageNo { get; set; }
        public bool IsDirtyField { get; set; }
        public bool IsNewField { get; set; }
        public bool IsOcrfield { get; set; }
        public bool IsInvoiceLine { get; set; }
        public bool Verified { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public int StateId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
