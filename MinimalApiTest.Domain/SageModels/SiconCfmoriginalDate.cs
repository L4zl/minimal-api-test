using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmoriginalDate
    {
        public long SiconCfmoriginalDateId { get; set; }
        public string OriginalDateSource { get; set; } = null!;
        public long? OriginalDateForeignId { get; set; }
        public DateTime? OriginalDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
