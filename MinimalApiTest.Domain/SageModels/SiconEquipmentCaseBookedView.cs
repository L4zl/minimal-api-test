using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipmentCaseBookedView
    {
        public long SiconEquipmentId { get; set; }
        public int? ActiveMaintenanceCases { get; set; }
        public int? ActiveCases { get; set; }
        public int? TotalCases { get; set; }
        public DateTime? EarliestIntervalDate { get; set; }
    }
}
