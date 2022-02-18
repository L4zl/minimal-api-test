using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaddLabEquipRateLine
    {
        public long SiSmaddLabEquipRateLineId { get; set; }
        public long SiSmcaseAddEquipLabourId { get; set; }
        public long SiJcTrnId { get; set; }
        public int? RateNumber { get; set; }
        public long? SiconTimesheetLineId { get; set; }
    }
}
