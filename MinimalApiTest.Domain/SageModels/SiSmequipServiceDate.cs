using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmequipServiceDate
    {
        public long SiSmequipServiceDateId { get; set; }
        public long SiSmserviceIntervalId { get; set; }
        public long SiconEquipmentId { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public DateTime? NextServiceDate { get; set; }
        public int? IntervalQuantityOverride { get; set; }
    }
}
