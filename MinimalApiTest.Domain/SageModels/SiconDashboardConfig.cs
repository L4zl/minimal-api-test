using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDashboardConfig
    {
        public long SiconDashboardConfigId { get; set; }
        public long? ModuleId { get; set; }
        public long? UserId { get; set; }
        public long? TeamId { get; set; }
        public int? PanelIndex { get; set; }
        public long? SiconDashboardPanelId { get; set; }
        public string? DashboardName { get; set; }
        public int? RefreshTimerMins { get; set; }
    }
}
