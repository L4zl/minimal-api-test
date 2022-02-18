using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSupplierKpiband
    {
        public long SiconDistSupplierKpibandId { get; set; }
        public string Name { get; set; } = null!;
        public int ToDay { get; set; }
        public int Points { get; set; }
        public byte ColourA { get; set; }
        public byte ColourR { get; set; }
        public byte ColourG { get; set; }
        public byte ColourB { get; set; }
        public bool FinalKpiband { get; set; }
    }
}
