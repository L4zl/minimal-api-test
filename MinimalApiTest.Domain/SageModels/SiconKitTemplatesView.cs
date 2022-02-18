using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitTemplatesView
    {
        public string KitItem { get; set; } = null!;
        public string? Components { get; set; }
        public decimal? LabourQuantity { get; set; }
        public decimal? MachineQuantity { get; set; }
    }
}
