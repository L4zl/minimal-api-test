using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIctemplateItem
    {
        public long SiconIctemplateItemId { get; set; }
        public long? SiconIctemplateId { get; set; }
        public string Company { get; set; } = null!;
        public int? Seq { get; set; }
        public long? NominalCodeId { get; set; }
        public string Acref { get; set; } = null!;
        public string Cc { get; set; } = null!;
        public string Dept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public long CompanyNumber { get; set; }
    }
}
