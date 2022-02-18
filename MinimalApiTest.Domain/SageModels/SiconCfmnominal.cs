using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmnominal
    {
        public long SiconCfmnominalId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public bool? LastDayOfMonth { get; set; }
        public short? DayOfMonth { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? SiconCfmsectionId { get; set; }
    }
}
