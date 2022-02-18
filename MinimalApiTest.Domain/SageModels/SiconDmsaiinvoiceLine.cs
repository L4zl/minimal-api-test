using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaiinvoiceLine
    {
        public long SiconDmsaiinvoiceLineId { get; set; }
        public long SiconDmsaiinvoiceId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
