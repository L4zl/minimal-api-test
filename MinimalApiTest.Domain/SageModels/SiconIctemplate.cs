using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIctemplate
    {
        public long SiconIctemplateId { get; set; }
        public string Name { get; set; } = null!;
        public string CreatedByUserId { get; set; } = null!;
        public DateTime? CreatedDateTime { get; set; }
        public string Type { get; set; } = null!;
        public string LastUsedByUserId { get; set; } = null!;
        public DateTime? LastUsedDateTime { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Description { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool IsSequential { get; set; }
        public bool IsJournal { get; set; }
    }
}
