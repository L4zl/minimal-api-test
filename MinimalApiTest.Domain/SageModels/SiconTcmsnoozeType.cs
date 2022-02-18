using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmsnoozeType
    {
        public long SiconTcmsnoozeTypeId { get; set; }
        public string SnoozeTypeName { get; set; } = null!;
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
