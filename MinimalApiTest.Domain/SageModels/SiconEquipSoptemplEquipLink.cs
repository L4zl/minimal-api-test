using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipSoptemplEquipLink
    {
        public long SiconEquipSoptemplEquipLinkId { get; set; }
        public long SiconEquipSoptemplId { get; set; }
        public long LinkedEquipSoptemplId { get; set; }
    }
}
