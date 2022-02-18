using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderNumber
    {
        public long SoporderNumberId { get; set; }
        public long NextSoporderNumber { get; set; }
    }
}
