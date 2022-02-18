using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDashboard
    {
        public long SiDashboardId { get; set; }
        public string SiDashboardName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool Published { get; set; }
        public string SiDashboardXml { get; set; } = null!;
    }
}
