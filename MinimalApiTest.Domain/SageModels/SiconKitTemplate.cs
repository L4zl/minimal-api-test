using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitTemplate
    {
        public SiconKitTemplate()
        {
            SiconKitTemplateLines = new HashSet<SiconKitTemplateLine>();
            SiconKits = new HashSet<SiconKit>();
        }

        public long SiconKitTemplateId { get; set; }
        public long? ItemId { get; set; }
        public decimal? LabourQuantity { get; set; }
        public decimal? MachineQuantity { get; set; }

        public virtual StockItem? Item { get; set; }
        public virtual ICollection<SiconKitTemplateLine> SiconKitTemplateLines { get; set; }
        public virtual ICollection<SiconKit> SiconKits { get; set; }
    }
}
