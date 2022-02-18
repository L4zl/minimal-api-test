using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcnllink
    {
        public long SiconJcnllinkId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? NlpostingId { get; set; }
        public long? Urn { get; set; }
        public long? SiJcTrnId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedUserId { get; set; }
    }
}
