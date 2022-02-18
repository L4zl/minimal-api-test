using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoporderLineStatus
    {
        public long SiconDistPoporderLineStatusId { get; set; }
        public string Status { get; set; } = null!;
        public byte ColourA { get; set; }
        public byte ColourR { get; set; }
        public byte ColourG { get; set; }
        public byte ColourB { get; set; }
    }
}
