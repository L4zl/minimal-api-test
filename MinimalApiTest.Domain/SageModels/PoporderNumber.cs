using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderNumber
    {
        public long PoporderNumberId { get; set; }
        public long NextPoporderNumber { get; set; }
    }
}
