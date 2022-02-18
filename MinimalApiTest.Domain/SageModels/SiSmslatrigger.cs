using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmslatrigger
    {
        public long SiSmslatriggerId { get; set; }
        public long? SiSmslaid { get; set; }
        public long? SiSmcaseTrackingStatusId { get; set; }
        public int? ActionId { get; set; }
        public decimal? LimitUnits { get; set; }
        public decimal? WarningUnits { get; set; }
    }
}
