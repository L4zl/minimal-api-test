using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAptResEquipRateLine
    {
        public long SiconAptResEquipRateLineId { get; set; }
        public long SiSmempLabourOnEquipmentCaseId { get; set; }
        public long SiJcTrnId { get; set; }
        public int? RateNumber { get; set; }
        public long? SiconTimesheetLineId { get; set; }
    }
}
