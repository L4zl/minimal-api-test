using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmequipServiceDateView
    {
        public long SiconEquipmentId { get; set; }
        public DateTime? EarliestNextServiceDate { get; set; }
    }
}
