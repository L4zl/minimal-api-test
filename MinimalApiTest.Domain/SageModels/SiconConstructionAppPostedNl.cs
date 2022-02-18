using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppPostedNl
    {
        public long SiconConstructionAppPostedNlid { get; set; }
        public string TranType { get; set; } = null!;
        public string LedgerType { get; set; } = null!;
        public long? TranId { get; set; }
        public long? NlpostingUrn { get; set; }
        public decimal? TranValue { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? TranDate { get; set; }
        public string TranStatus { get; set; } = null!;
    }
}
