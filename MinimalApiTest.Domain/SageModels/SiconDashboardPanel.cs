using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDashboardPanel
    {
        public long SiconDashboardPanelId { get; set; }
        public string? Name { get; set; }
        public string? PanelType { get; set; }
        public long? ModuleId { get; set; }
    }
}
