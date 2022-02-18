using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistributionDocument
    {
        public long SiconDmsdistributionDocumentId { get; set; }
        public long SiconDmsdistrubutionReportId { get; set; }
        public long StockItemId { get; set; }
        public long SiconDmsdocumentId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
