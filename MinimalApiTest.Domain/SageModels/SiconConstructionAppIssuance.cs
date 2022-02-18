using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppIssuance
    {
        public long SiconConstructionAppIssuanceId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SupplierAccountId { get; set; }
        public int? NextApplicationNo { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public string? Ledger { get; set; }
        public bool? IsReserved { get; set; }
    }
}
