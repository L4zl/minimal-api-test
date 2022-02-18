using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsswitchField
    {
        public long SiconDmsaiswitchFieldId { get; set; }
        public long SiconDmssupplierId { get; set; }
        public string Name { get; set; } = null!;
        public short PageNo { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public string Value { get; set; } = null!;
        public string SwitchValue { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
