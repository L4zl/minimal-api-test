using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprequisitionNumber
    {
        public long PoprequisitionNumberId { get; set; }
        public long NextPoprequisitionNumber { get; set; }
    }
}
