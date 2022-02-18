using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaitemplateField
    {
        public long SiconDmsaitemplateFieldId { get; set; }
        public long SiconDmsaitemplateId { get; set; }
        public string Name { get; set; } = null!;
        public short PageNo { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
