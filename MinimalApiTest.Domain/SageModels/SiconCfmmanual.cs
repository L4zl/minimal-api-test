using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmmanual
    {
        public long SiconCfmmanualId { get; set; }
        public long? SiconCfmsectionId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public decimal ManualValue { get; set; }
        public DateTime? StartDate { get; set; }
        public string RecursionType { get; set; } = null!;
        public string RecursionPeriod { get; set; } = null!;
        public int RecursionInterval { get; set; }
        public bool RecursionIndefinite { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? EndDate { get; set; }
        public bool Paid { get; set; }
    }
}
